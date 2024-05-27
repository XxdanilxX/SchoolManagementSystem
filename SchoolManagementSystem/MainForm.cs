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
            LoadClassesData();

            // Додаємо обробник події FormClosed
            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
        }

        // Метод для завершення процесу при закритті форми
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
            }
        }

        private void LoadClassesData()
        {
            using (var conn = DBUtils.GetDBConnection())
            {
               /* conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Classes", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                classesGridView.DataSource = dt;*/
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Students (LastName, FirstName, BirthDate, Class, Group) VALUES (@LastName, @FirstName, @BirthDate, @Class, @Group)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@BirthDate", birthDatePicker.Value);
                cmd.Parameters.AddWithValue("@Class", classTextBox.Text);
                cmd.Parameters.AddWithValue("@Group", groupTextBox.Text);
                cmd.ExecuteNonQuery();
            }
            LoadStudentsData();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Teachers (LastName, FirstName, Subject, Qualification, Schedule) VALUES (@LastName, @FirstName, @Subject, @Qualification, @Schedule)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBoxTeacher.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBoxTeacher.Text);
                cmd.Parameters.AddWithValue("@Subject", subjectTextBox.Text);
                cmd.Parameters.AddWithValue("@Qualification", qualificationTextBox.Text);
                cmd.Parameters.AddWithValue("@Schedule", scheduleTextBox.Text);
                cmd.ExecuteNonQuery();
            }
            LoadTeachersData();
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Grades (StudentId, TeacherId, Grade, DateAssigned) VALUES (@StudentId, @TeacherId, @Grade, @DateAssigned)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentIdTextBox.Text);
                cmd.Parameters.AddWithValue("@TeacherId", teacherIdTextBox.Text);
                cmd.Parameters.AddWithValue("@Grade", gradeTextBox.Text);
                cmd.Parameters.AddWithValue("@DateAssigned", dateAssignedPicker.Value);
                cmd.ExecuteNonQuery();
            }
            LoadGradesData();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Tasks (TaskType, Description, Status, CreationDate, CompletionDate, StudentId, TeacherId) VALUES (@TaskType, @Description, @Status, @CreationDate, @CompletionDate, @StudentId, @TeacherId)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TaskType", taskTypeTextBox.Text);
                cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@Status", statusTextBox.Text);
                cmd.Parameters.AddWithValue("@CreationDate", creationDatePicker.Value);
                cmd.Parameters.AddWithValue("@CompletionDate", completionDatePicker.Value);
                cmd.Parameters.AddWithValue("@StudentId", studentIdTaskTextBox.Text);
                cmd.Parameters.AddWithValue("@TeacherId", teacherIdTaskTextBox.Text);
                cmd.ExecuteNonQuery();
            }
            LoadTasksData();
        }

        private void manageClassesButton_Click(object sender, EventArgs e)
        {
            /*using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "INSERT INTO Classes (ClassName) VALUES (@ClassName)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassName", classListTextBox.Text);
                cmd.ExecuteNonQuery();
            }
            LoadClassesData();*/
        }
    }
}
