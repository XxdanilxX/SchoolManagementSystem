using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    public partial class MainForm : Form
    {
        private string role;
        private string userLogin;
        public string userId;
        
        public MainForm(string role, string userLogin, string userId)
        {
            InitializeComponent();
            this.role = role;
            this.userLogin = userLogin;
            this.userId = userId;
            this.Load += new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConfigureAccessBasedOnRole();
            LoadData();

            label3.Text = "Ваш ID: " + userId;
        }

        private void ConfigureAccessBasedOnRole()
        {
            switch (role)
            {
                case "Admin":
                    // Адміністратор має доступ до всіх функцій
                    break;
                case "Teacher":
                    ConfigureTeacherAccess();
                    break;
                case "Student":
                    ConfigureStudentAccess();
                    break;
            }
        }

        private void ConfigureTeacherAccess()
        {
            if (studentsGridView.Columns.Contains("StudentIdentifier"))
            {
                studentsGridView.Columns["StudentIdentifier"].Visible = false;
            }

            addStudentButton.Enabled = false;
            updateStudentButton.Enabled = false;
            deleteStudentButton.Enabled = false;

            if (teachersGridView.Columns.Contains("TeacherIdentifier"))
            {
                teachersGridView.Columns["TeacherIdentifier"].Visible = false;
            }

            addTeacherButton.Enabled = false;
            updateTeacherButton.Enabled = false;
            deleteTeacherButton.Enabled = false;

            teacherIdTextBox.Enabled = false;
            teacherIdTextBox.Text = userId; // Використання id вчителя

            teacherIdTaskTextBox.Enabled = false;
            teacherIdTaskTextBox.Text = userId; // Використання id вчителя
        }

        private void ConfigureStudentAccess()
        {
            if (studentsGridView.Columns.Contains("StudentIdentifier"))
            {
                studentsGridView.Columns["StudentIdentifier"].Visible = false;
            }

            addStudentButton.Enabled = false;
            updateStudentButton.Enabled = false;
            deleteStudentButton.Enabled = false;

            if (teachersGridView.Columns.Contains("TeacherIdentifier"))
            {
                teachersGridView.Columns["TeacherIdentifier"].Visible = false;
            }

            addTeacherButton.Enabled = false;
            updateTeacherButton.Enabled = false;
            deleteTeacherButton.Enabled = false;

            studentIdTextBox.Text = userId; // Використання id учня
            studentIdTextBox.Enabled = false;

            addTaskButton.Enabled = false;
            deleteTaskButton.Enabled = false;
            updateTaskButton.Enabled = false;

            // Заблокувати всі кнопки крім фільтрувати у формі Виставлення оцінок
            addGradeButton.Enabled = false;
            updateGradeButton.Enabled = false;
            deleteGradeButton.Enabled = false;

            // Завантажити тільки завдання для цього учня
            LoadTasksDataForStudent();
        }

        private void LoadData()
        {
            LoadStudentsData();
            LoadTeachersData();
            LoadGradesData();
            LoadTasksData();
        }
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(userLogin);
            changePasswordForm.ShowDialog();
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

                if (role == "Teacher" || role == "Student")
                {
                    studentsGridView.Columns["StudentIdentifier"].Visible = false;
                }
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

                if (role == "Teacher" || role == "Student")
                {
                    teachersGridView.Columns["TeacherIdentifier"].Visible = false;
                }
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

                if (role == "Student")
                {
                    query += " WHERE g.StudentID = @StudentID";
                }

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                if (role == "Student")
                {
                    da.SelectCommand.Parameters.AddWithValue("@StudentID", userId);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                gradesGridView.DataSource = dt;
            }
        }

        private void LoadTasksData()
        {
            if (role == "Student")
            {
                LoadTasksDataForStudent();
                return;
            }

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
            }
        }
         
        private void LoadTasksDataForStudent()
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = @"
                    SELECT t.TaskID, t.TaskType, t.Description, t.Status, t.CreationDate, t.CompletionDate, 
                           t.StudentID, t.TeacherID, s.Class, s.StudentGroup
                    FROM Tasks t
                    JOIN Students s ON t.StudentID = s.StudentID
                    WHERE t.StudentID = @StudentID";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@StudentID", userId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tasksGridView.DataSource = dt;
            }
        }

        // Додавання, оновлення, видалення та фільтрація учнів
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при додаванні учня: " + ex.Message);
            }
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при оновленні учня: " + ex.Message);
            }
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при видаленні учня: " + ex.Message);
            }
        }

        private void filterStudentsButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при фільтрації учнів: " + ex.Message);
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

        // Додавання, оновлення, видалення та фільтрація вчителів
        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при додаванні вчителя: " + ex.Message);
            }
        }

        private void updateTeacherButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при оновленні вчителя: " + ex.Message);
            }
        }

        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при видаленні вчителя: " + ex.Message);
            }
        }

        private void filterTeachersButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при фільтрації вчителів: " + ex.Message);
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

        // Додавання, оновлення, видалення та фільтрація оцінок
        private void addGradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Grades (StudentID, TeacherID, Grade, DateAssigned) VALUES (@StudentID, @TeacherID, @Grade, @DateAssigned)", conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@TeacherID", userId); // Використання id вчителя
                    cmd.Parameters.AddWithValue("@Grade", gradeTextBox.Text);
                    cmd.Parameters.AddWithValue("@DateAssigned", dateAssignedPicker.Value.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
                LoadGradesData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при додаванні оцінки: " + ex.Message);
            }
        }

        private void updateGradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gradesGridView.SelectedRows.Count > 0)
                {
                    using (var conn = DBUtils.GetDBConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE Grades SET StudentID=@StudentID, TeacherID=@TeacherID, Grade=@Grade, DateAssigned=@DateAssigned WHERE GradeID=@GradeID", conn);
                        cmd.Parameters.AddWithValue("@GradeID", gradesGridView.SelectedRows[0].Cells["GradeID"].Value);
                        cmd.Parameters.AddWithValue("@StudentID", studentIdTextBox.Text);
                        cmd.Parameters.AddWithValue("@TeacherID", userId); // Використання id вчителя
                        cmd.Parameters.AddWithValue("@Grade", gradeTextBox.Text);
                        cmd.Parameters.AddWithValue("@DateAssigned", dateAssignedPicker.Value.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                    }
                    LoadGradesData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при оновленні оцінки: " + ex.Message);
            }
        }

        private void deleteGradeButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при видаленні оцінки: " + ex.Message);
            }
        }

        private void filterGradesButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при фільтрації оцінок: " + ex.Message);
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

        // Додавання, оновлення, видалення та фільтрація завдань
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            try
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
                        cmd.Parameters.AddWithValue("@TeacherID", userId); // Використання id вчителя
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadTasksData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при додаванні завдання: " + ex.Message);
            }
        }

        private void updateTaskButton_Click(object sender, EventArgs e)
        {
            try
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
                        cmd.Parameters.AddWithValue("@StudentID", tasksGridView.SelectedRows[0].Cells["StudentID"].Value);
                        cmd.Parameters.AddWithValue("@TeacherID", userId); // Використання id вчителя
                        cmd.ExecuteNonQuery();
                    }
                    LoadTasksData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при оновленні завдання: " + ex.Message);
            }
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при видаленні завдання: " + ex.Message);
            }
        }

        private void filterTasksButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при фільтрації завдань: " + ex.Message);
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
            try
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
            catch (Exception ex)
            {
                
            }
        }

        private void teacherIdTextBox_Leave(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при отриманні інформації про вчителя: " + ex.Message);
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
