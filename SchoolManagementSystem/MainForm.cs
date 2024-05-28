using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadStudentsData();
            LoadTeachersData();
            LoadGradesData();
            LoadTasksData();

            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadStudentsData()
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Students", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                studentsGridView.DataSource = dt;

                // Налаштовуємо заголовки стовпців
                studentsGridView.Columns["StudentID"].HeaderText = "ID";
                studentsGridView.Columns["LastName"].HeaderText = "Прізвище";
                studentsGridView.Columns["FirstName"].HeaderText = "Ім'я";
                studentsGridView.Columns["BirthDate"].HeaderText = "Дата народження";
                studentsGridView.Columns["Class"].HeaderText = "Клас";
                studentsGridView.Columns["StudentGroup"].HeaderText = "Група";
                studentsGridView.Columns["StudentIdentifier"].HeaderText = "Ідентифікатор";
            }
        }

        private void LoadTeachersData()
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Teachers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                teachersGridView.DataSource = dt;

                // Налаштовуємо заголовки стовпців
                teachersGridView.Columns["TeacherID"].HeaderText = "ID";
                teachersGridView.Columns["LastName"].HeaderText = "Прізвище";
                teachersGridView.Columns["FirstName"].HeaderText = "Ім'я";
                teachersGridView.Columns["Subject"].HeaderText = "Предмет";
                teachersGridView.Columns["Qualification"].HeaderText = "Кваліфікація";
                teachersGridView.Columns["TeacherIdentifier"].HeaderText = "Ідентифікатор";
            }
        }

        private void LoadGradesData()
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = @"
            SELECT g.GradeID, g.StudentID, CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, 
                   s.Class AS StudentClass, s.StudentGroup, 
                   CONCAT(t.FirstName, ' ', t.LastName) AS TeacherName, g.TeacherID, 
                   g.Grade, g.DateAssigned
            FROM Grades g
            JOIN Students s ON g.StudentID = s.StudentID
            JOIN Teachers t ON g.TeacherID = t.TeacherID";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gradesGridView.DataSource = dt;

                // Налаштовуємо заголовки стовпців
                gradesGridView.Columns["GradeID"].HeaderText = "ID";
                gradesGridView.Columns["StudentID"].HeaderText = "ID учня";
                gradesGridView.Columns["StudentName"].HeaderText = "Ім'я учня";
                gradesGridView.Columns["StudentClass"].HeaderText = "Клас";
                gradesGridView.Columns["StudentGroup"].HeaderText = "Група";
                gradesGridView.Columns["TeacherName"].HeaderText = "Ім'я вчителя";
                gradesGridView.Columns["TeacherID"].HeaderText = "ID вчителя";
                gradesGridView.Columns["Grade"].HeaderText = "Оцінка";
                gradesGridView.Columns["DateAssigned"].HeaderText = "Дата виставлення";
            }
        }

        private void LoadTasksData()
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = @"
                    SELECT t.TaskID, t.TaskType, t.Description, t.Status, t.CreationDate, t.CompletionDate, 
                           t.StudentID, t.TeacherID, s.Class, s.StudentGroup
                    FROM Tasks t
                    JOIN Students s ON t.StudentID = s.StudentID";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tasksGridView.DataSource = dt;

                // Налаштовуємо заголовки стовпців
                tasksGridView.Columns["TaskID"].HeaderText = "ID";
                tasksGridView.Columns["TaskType"].HeaderText = "Тип завдання";
                tasksGridView.Columns["Description"].HeaderText = "Опис";
                tasksGridView.Columns["Status"].HeaderText = "Статус";
                tasksGridView.Columns["CreationDate"].HeaderText = "Дата створення";
                tasksGridView.Columns["CompletionDate"].HeaderText = "Дата завершення";
                tasksGridView.Columns["StudentID"].HeaderText = "ID учня";
                tasksGridView.Columns["TeacherID"].HeaderText = "ID вчителя";
                tasksGridView.Columns["Class"].HeaderText = "Клас";
                tasksGridView.Columns["StudentGroup"].HeaderText = "Група";
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Students (LastName, FirstName, BirthDate, Class, StudentGroup, StudentIdentifier) VALUES (@LastName, @FirstName, @BirthDate, @Class, @StudentGroup, @StudentIdentifier)", conn);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@BirthDate", birthDatePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Class", classTextBox.Text);
                cmd.Parameters.AddWithValue("@StudentGroup", groupTextBox.Text);
                cmd.Parameters.AddWithValue("@StudentIdentifier", identifierTextBox.Text);
                cmd.ExecuteNonQuery();

                MySqlCommand authCmd = new MySqlCommand("INSERT INTO Authorization (Login, Password, Role, StudentIdentifier) VALUES (@Login, @Password, 'Student', @StudentIdentifier)", conn);
                authCmd.Parameters.AddWithValue("@Login", identifierTextBox.Text);
                authCmd.Parameters.AddWithValue("@Password", ComputeSha256Hash("pass"));
                authCmd.Parameters.AddWithValue("@StudentIdentifier", identifierTextBox.Text);
                authCmd.ExecuteNonQuery();
            }
            LoadStudentsData();
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            if (studentsGridView.SelectedRows.Count > 0)
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Students SET LastName=@LastName, FirstName=@FirstName, BirthDate=@BirthDate, Class=@Class, StudentGroup=@StudentGroup, StudentIdentifier=@StudentIdentifier WHERE StudentID=@StudentID", conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentsGridView.SelectedRows[0].Cells["StudentID"].Value);
                    cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", birthDatePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Class", classTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentGroup", groupTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentIdentifier", identifierTextBox.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadStudentsData();
            }
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (studentsGridView.SelectedRows.Count > 0)
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Students WHERE StudentID=@StudentID", conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentsGridView.SelectedRows[0].Cells["StudentID"].Value);
                    cmd.ExecuteNonQuery();

                    MySqlCommand authCmd = new MySqlCommand("DELETE FROM Authorization WHERE StudentIdentifier=@StudentIdentifier", conn);
                    authCmd.Parameters.AddWithValue("@StudentIdentifier", studentsGridView.SelectedRows[0].Cells["StudentIdentifier"].Value);
                    authCmd.ExecuteNonQuery();
                }
                LoadStudentsData();
            }
        }

        private void filterStudentsButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Students WHERE StudentGroup = @StudentGroup OR Class = @StudentGroup";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@StudentGroup", filterStudentsTextBox.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                studentsGridView.DataSource = dt;
            }
        }

        private void studentsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = studentsGridView.Rows[e.RowIndex];
                lastNameTextBox.Text = row.Cells["LastName"].Value.ToString();
                firstNameTextBox.Text = row.Cells["FirstName"].Value.ToString();
                birthDatePicker.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                classTextBox.Text = row.Cells["Class"].Value.ToString();
                groupTextBox.Text = row.Cells["StudentGroup"].Value.ToString();
                identifierTextBox.Text = row.Cells["StudentIdentifier"].Value.ToString();
            }
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Teachers (LastName, FirstName, Subject, Qualification, TeacherIdentifier) VALUES (@LastName, @FirstName, @Subject, @Qualification, @TeacherIdentifier)", conn);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBoxTeacher.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBoxTeacher.Text);
                cmd.Parameters.AddWithValue("@Subject", subjectTextBox.Text);
                cmd.Parameters.AddWithValue("@Qualification", qualificationTextBox.Text);
                cmd.Parameters.AddWithValue("@TeacherIdentifier", identifierTextBoxTeacher.Text);
                cmd.ExecuteNonQuery();

                MySqlCommand authCmd = new MySqlCommand("INSERT INTO Authorization (Login, Password, Role, TeacherIdentifier) VALUES (@Login, @Password, 'Teacher', @TeacherIdentifier)", conn);
                authCmd.Parameters.AddWithValue("@Login", identifierTextBoxTeacher.Text);
                authCmd.Parameters.AddWithValue("@Password", ComputeSha256Hash("pass"));
                authCmd.Parameters.AddWithValue("@TeacherIdentifier", identifierTextBoxTeacher.Text);
                authCmd.ExecuteNonQuery();
            }
            LoadTeachersData();
        }

        private void updateTeacherButton_Click(object sender, EventArgs e)
        {
            if (teachersGridView.SelectedRows.Count > 0)
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Teachers SET LastName=@LastName, FirstName=@FirstName, Subject=@Subject, Qualification=@Qualification, TeacherIdentifier=@TeacherIdentifier WHERE TeacherID=@TeacherID", conn);
                    cmd.Parameters.AddWithValue("@TeacherID", teachersGridView.SelectedRows[0].Cells["TeacherID"].Value);
                    cmd.Parameters.AddWithValue("@LastName", lastNameTextBoxTeacher.Text);
                    cmd.Parameters.AddWithValue("@FirstName", firstNameTextBoxTeacher.Text);
                    cmd.Parameters.AddWithValue("@Subject", subjectTextBox.Text);
                    cmd.Parameters.AddWithValue("@Qualification", qualificationTextBox.Text);
                    cmd.Parameters.AddWithValue("@TeacherIdentifier", identifierTextBoxTeacher.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadTeachersData();
            }
        }

        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {
            if (teachersGridView.SelectedRows.Count > 0)
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Teachers WHERE TeacherID=@TeacherID", conn);
                    cmd.Parameters.AddWithValue("@TeacherID", teachersGridView.SelectedRows[0].Cells["TeacherID"].Value);
                    cmd.ExecuteNonQuery();

                    MySqlCommand authCmd = new MySqlCommand("DELETE FROM Authorization WHERE TeacherIdentifier=@TeacherIdentifier", conn);
                    authCmd.Parameters.AddWithValue("@TeacherIdentifier", teachersGridView.SelectedRows[0].Cells["TeacherIdentifier"].Value);
                    authCmd.ExecuteNonQuery();
                }
                LoadTeachersData();
            }
        }

        private void filterTeachersButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Teachers WHERE LastName LIKE @Filter OR FirstName LIKE @Filter";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filterTeachersTextBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                teachersGridView.DataSource = dt;
            }
        }

        private void teachersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = teachersGridView.Rows[e.RowIndex];
                lastNameTextBoxTeacher.Text = row.Cells["LastName"].Value.ToString();
                firstNameTextBoxTeacher.Text = row.Cells["FirstName"].Value.ToString();
                subjectTextBox.Text = row.Cells["Subject"].Value.ToString();
                qualificationTextBox.Text = row.Cells["Qualification"].Value.ToString();
                identifierTextBoxTeacher.Text = row.Cells["TeacherIdentifier"].Value.ToString();
            }
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Grades (StudentID, TeacherID, Grade, DateAssigned) VALUES (@StudentID, @TeacherID, @Grade, @DateAssigned)", conn);
                cmd.Parameters.AddWithValue("@StudentID", studentIdTextBox.Text);
                cmd.Parameters.AddWithValue("@TeacherID", teacherIdTextBox.Text);
                cmd.Parameters.AddWithValue("@Grade", gradeTextBox.Text);
                cmd.Parameters.AddWithValue("@DateAssigned", dateAssignedPicker.Value.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
            }
            LoadGradesData();
        }

        private void updateGradeButton_Click(object sender, EventArgs e)
        {
            if (gradesGridView.SelectedRows.Count > 0)
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Grades SET StudentID=@StudentID, TeacherID=@TeacherID, Grade=@Grade, DateAssigned=@DateAssigned WHERE GradeID=@GradeID", conn);
                    cmd.Parameters.AddWithValue("@GradeID", gradesGridView.SelectedRows[0].Cells["GradeID"].Value);
                    cmd.Parameters.AddWithValue("@StudentID", studentIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@TeacherID", teacherIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@Grade", gradeTextBox.Text);
                    cmd.Parameters.AddWithValue("@DateAssigned", dateAssignedPicker.Value.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
                LoadGradesData();
            }
        }

        private void deleteGradeButton_Click(object sender, EventArgs e)
        {
            if (gradesGridView.SelectedRows.Count > 0)
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Grades WHERE GradeID=@GradeID", conn);
                    cmd.Parameters.AddWithValue("@GradeID", gradesGridView.SelectedRows[0].Cells["GradeID"].Value);
                    cmd.ExecuteNonQuery();
                }
                LoadGradesData();
            }
        }

        private void filterGradesButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Grades WHERE StudentID LIKE @Filter OR TeacherID LIKE @Filter";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filterGradesTextBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                gradesGridView.DataSource = dt;
            }
        }

        private void gradesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gradesGridView.Rows[e.RowIndex];
                studentIdTextBox.Text = row.Cells["StudentID"].Value.ToString();
                teacherIdTextBox.Text = row.Cells["TeacherID"].Value.ToString();
                gradeTextBox.Text = row.Cells["Grade"].Value.ToString();
                dateAssignedPicker.Value = Convert.ToDateTime(row.Cells["DateAssigned"].Value);

                studentNameTextBox.Text = row.Cells["StudentName"].Value.ToString();
                studentClassTextBox.Text = row.Cells["StudentClass"].Value.ToString();
                studentGroupTextBox.Text = row.Cells["StudentGroup"].Value.ToString();
                teacherNameTextBox.Text = row.Cells["TeacherName"].Value.ToString();
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                // Отримуємо список студентів за класом та групою
                MySqlCommand getStudentsCmd = new MySqlCommand("SELECT StudentID FROM Students WHERE Class=@Class AND StudentGroup=@StudentGroup", conn);
                getStudentsCmd.Parameters.AddWithValue("@Class", classTextBoxTask.Text);
                getStudentsCmd.Parameters.AddWithValue("@StudentGroup", groupTextBoxTask.Text);

                MySqlDataReader reader = getStudentsCmd.ExecuteReader();
                var studentIds = new List<int>();
                while (reader.Read())
                {
                    studentIds.Add(reader.GetInt32("StudentID"));
                }
                reader.Close();

                // Додаємо завдання для кожного студента з цього списку
                foreach (var studentId in studentIds)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Tasks (TaskType, Description, Status, CreationDate, CompletionDate, StudentID, TeacherID) VALUES (@TaskType, @Description, @Status, @CreationDate, @CompletionDate, @StudentID, @TeacherID)", conn);
                    cmd.Parameters.AddWithValue("@TaskType", taskTypeTextBox.Text);
                    cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@Status", statusTextBox.Text);
                    cmd.Parameters.AddWithValue("@CreationDate", creationDatePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@CompletionDate", completionDatePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@TeacherID", teacherIdTaskTextBox.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadTasksData();
        }

        private void updateTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksGridView.SelectedRows.Count > 0)
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Tasks SET TaskType=@TaskType, Description=@Description, Status=@Status, CreationDate=@CreationDate, CompletionDate=@CompletionDate, StudentID=@StudentID, TeacherID=@TeacherID WHERE TaskID=@TaskID", conn);
                    cmd.Parameters.AddWithValue("@TaskID", tasksGridView.SelectedRows[0].Cells["TaskID"].Value);
                    cmd.Parameters.AddWithValue("@TaskType", taskTypeTextBox.Text);
                    cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@Status", statusTextBox.Text);
                    cmd.Parameters.AddWithValue("@CreationDate", creationDatePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@CompletionDate", completionDatePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@TeacherID", teacherIdTaskTextBox.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadTasksData();
            }
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksGridView.SelectedRows.Count > 0)
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Tasks WHERE TaskID=@TaskID", conn);
                    cmd.Parameters.AddWithValue("@TaskID", tasksGridView.SelectedRows[0].Cells["TaskID"].Value);
                    cmd.ExecuteNonQuery();
                }
                LoadTasksData();
            }
        }

        private void filterTasksButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = @"
            SELECT t.TaskID, t.TaskType, t.Description, t.Status, t.CreationDate, t.CompletionDate, 
                   t.StudentID, t.TeacherID, s.Class, s.StudentGroup
            FROM Tasks t
            JOIN Students s ON t.StudentID = s.StudentID
            WHERE s.Class = @Class AND s.StudentGroup = @StudentGroup";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                string[] filterParts = filterTasksTextBox.Text.Split(new char[] { ' ' }, 2);
                if (filterParts.Length == 2)
                {
                    da.SelectCommand.Parameters.AddWithValue("@Class", filterParts[0]);
                    da.SelectCommand.Parameters.AddWithValue("@StudentGroup", filterParts[1]);
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть клас та групу у правильному форматі (наприклад, '10 A').");
                    return;
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                tasksGridView.DataSource = dt;
            }
        }



        private void tasksGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tasksGridView.Rows[e.RowIndex];
                taskTypeTextBox.Text = row.Cells["TaskType"].Value.ToString();
                descriptionTextBox.Text = row.Cells["Description"].Value.ToString();
                statusTextBox.Text = row.Cells["Status"].Value.ToString();
                creationDatePicker.Value = Convert.ToDateTime(row.Cells["CreationDate"].Value);
                completionDatePicker.Value = Convert.ToDateTime(row.Cells["CompletionDate"].Value);
                teacherIdTaskTextBox.Text = row.Cells["TeacherID"].Value.ToString();
                classTextBoxTask.Text = row.Cells["Class"].Value.ToString();
                groupTextBoxTask.Text = row.Cells["StudentGroup"].Value.ToString();
            }
        }

        private void studentIdTextBox_Leave(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT LastName, FirstName, Class, StudentGroup FROM Students WHERE StudentID = @StudentID", conn);
                cmd.Parameters.AddWithValue("@StudentID", studentIdTextBox.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    studentNameTextBox.Text = reader["LastName"].ToString() + " " + reader["FirstName"].ToString();
                    studentClassTextBox.Text = reader["Class"].ToString();
                    studentGroupTextBox.Text = reader["StudentGroup"].ToString();
                }
                reader.Close();
            }
        }

        private void teacherIdTextBox_Leave(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT LastName, FirstName FROM Teachers WHERE TeacherID = @TeacherID", conn);
                cmd.Parameters.AddWithValue("@TeacherID", teacherIdTextBox.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    teacherNameTextBox.Text = reader["LastName"].ToString() + " " + reader["FirstName"].ToString();
                }
                reader.Close();
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));
                var builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
