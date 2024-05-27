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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Grades", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gradesGridView.DataSource = dt;

                // Налаштовуємо заголовки стовпців
                gradesGridView.Columns["GradeID"].HeaderText = "ID";
                gradesGridView.Columns["StudentID"].HeaderText = "ID учня";
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Tasks", conn);
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
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Students (LastName, FirstName, BirthDate, Class, StudentGroup, StudentIdentifier) VALUES (@LastName, @FirstName, @BirthDate, @Class, @StudentGroup, @StudentIdentifier)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@BirthDate", birthDatePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Class", classTextBox.Text);
                cmd.Parameters.AddWithValue("@StudentGroup", groupTextBox.Text);
                cmd.Parameters.AddWithValue("@StudentIdentifier", Guid.NewGuid().ToString());
                cmd.ExecuteNonQuery();
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
                    string query = "UPDATE Students SET LastName=@LastName, FirstName=@FirstName, BirthDate=@BirthDate, Class=@Class, StudentGroup=@StudentGroup WHERE StudentID=@StudentID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentsGridView.SelectedRows[0].Cells["StudentID"].Value);
                    cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", birthDatePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Class", classTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentGroup", groupTextBox.Text);
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
                    string query = "DELETE FROM Students WHERE StudentID=@StudentID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentsGridView.SelectedRows[0].Cells["StudentID"].Value);
                    cmd.ExecuteNonQuery();
                }
                LoadStudentsData();
            }
        }

        private void filterStudentsButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Students WHERE StudentGroup = @StudentGroup";
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
            }
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Teachers (LastName, FirstName, Subject, Qualification, TeacherIdentifier) VALUES (@LastName, @FirstName, @Subject, @Qualification, @TeacherIdentifier)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBoxTeacher.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBoxTeacher.Text);
                cmd.Parameters.AddWithValue("@Subject", subjectTextBox.Text);
                cmd.Parameters.AddWithValue("@Qualification", qualificationTextBox.Text);
                cmd.Parameters.AddWithValue("@TeacherIdentifier", Guid.NewGuid().ToString());
                cmd.ExecuteNonQuery();
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
                    string query = "UPDATE Teachers SET LastName=@LastName, FirstName=@FirstName, Subject=@Subject, Qualification=@Qualification WHERE TeacherID=@TeacherID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TeacherID", teachersGridView.SelectedRows[0].Cells["TeacherID"].Value);
                    cmd.Parameters.AddWithValue("@LastName", lastNameTextBoxTeacher.Text);
                    cmd.Parameters.AddWithValue("@FirstName", firstNameTextBoxTeacher.Text);
                    cmd.Parameters.AddWithValue("@Subject", subjectTextBox.Text);
                    cmd.Parameters.AddWithValue("@Qualification", qualificationTextBox.Text);
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
                    string query = "DELETE FROM Teachers WHERE TeacherID=@TeacherID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TeacherID", teachersGridView.SelectedRows[0].Cells["TeacherID"].Value);
                    cmd.ExecuteNonQuery();
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
            }
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Grades (StudentID, TeacherID, Grade, DateAssigned) VALUES (@StudentID, @TeacherID, @Grade, @DateAssigned)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
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
                    string query = "UPDATE Grades SET StudentID=@StudentID, TeacherID=@TeacherID, Grade=@Grade, DateAssigned=@DateAssigned WHERE GradeID=@GradeID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
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
                    string query = "DELETE FROM Grades WHERE GradeID=@GradeID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
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
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Tasks (TaskType, Description, Status, CreationDate, CompletionDate, StudentID, TeacherID) VALUES (@TaskType, @Description, @Status, @CreationDate, @CompletionDate, @StudentID, @TeacherID)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TaskType", taskTypeTextBox.Text);
                cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@Status", statusTextBox.Text);
                cmd.Parameters.AddWithValue("@CreationDate", creationDatePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@CompletionDate", completionDatePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@StudentID", studentIdTaskTextBox.Text);
                cmd.Parameters.AddWithValue("@TeacherID", teacherIdTaskTextBox.Text);
                cmd.ExecuteNonQuery();
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
                    string query = "UPDATE Tasks SET TaskType=@TaskType, Description=@Description, Status=@Status, CreationDate=@CreationDate, CompletionDate=@CompletionDate, StudentID=@StudentID, TeacherID=@TeacherID WHERE TaskID=@TaskID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskID", tasksGridView.SelectedRows[0].Cells["TaskID"].Value);
                    cmd.Parameters.AddWithValue("@TaskType", taskTypeTextBox.Text);
                    cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@Status", statusTextBox.Text);
                    cmd.Parameters.AddWithValue("@CreationDate", creationDatePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@CompletionDate", completionDatePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@StudentID", studentIdTaskTextBox.Text);
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
                    string query = "DELETE FROM Tasks WHERE TaskID=@TaskID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
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
                string query = "SELECT * FROM Tasks WHERE TaskType LIKE @Filter OR Description LIKE @Filter";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filterTasksTextBox.Text + "%");
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
                studentIdTaskTextBox.Text = row.Cells["StudentID"].Value.ToString();
                teacherIdTaskTextBox.Text = row.Cells["TeacherID"].Value.ToString();
            }
        }
    }
}
