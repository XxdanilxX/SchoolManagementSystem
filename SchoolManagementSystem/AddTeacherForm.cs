using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string subject = subjectTextBox.Text;
            string qualification = qualificationTextBox.Text;
            string schedule = scheduleTextBox.Text;

            MySqlConnection connection = DBUtils.GetDBConnection();

            try
            {
                connection.Open();
                string query = "INSERT INTO Teachers (Прізвище, Ім_я, Предмет, Кваліфікація, Графік_роботи) VALUES (@lastName, @firstName, @subject, @qualification, @schedule)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@subject", subject);
                command.Parameters.AddWithValue("@qualification", qualification);
                command.Parameters.AddWithValue("@schedule", schedule);

                command.ExecuteNonQuery();
                MessageBox.Show("Teacher added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
