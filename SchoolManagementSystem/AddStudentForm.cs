using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string lastName = surnameTextBox.Text;
            string firstName = nameTextBox.Text;
            DateTime birthDate = birthDatePicker.Value;
            string studentClass = classComboBox.Text;
            string group = groupTextBox.Text;

            MySqlConnection connection = DBUtils.GetDBConnection();

            try
            {
                connection.Open();
                string query = "INSERT INTO Students (Прізвище, Ім_я, Дата_народження, Клас, Група, Ідентифікатор) VALUES (@lastName, @firstName, @birthDate, @class, @group, @identifier)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@birthDate", birthDate);
                command.Parameters.AddWithValue("@class", studentClass);
                command.Parameters.AddWithValue("@group", group);
                command.Parameters.AddWithValue("@identifier", Guid.NewGuid().ToString());

                command.ExecuteNonQuery();
                MessageBox.Show("Student added successfully.");
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
