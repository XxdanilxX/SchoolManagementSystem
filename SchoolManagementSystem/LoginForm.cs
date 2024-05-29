using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string login = loginTextBox.Text;
                string password = passwordTextBox.Text;

                if (AuthenticateUser(login, password))
                {
                    string role = GetUserRole(login);
                    if (string.IsNullOrEmpty(role))
                    {
                        MessageBox.Show("Роль користувача не визначена.");
                        return;
                    }

                    string userId = GetUserId(login, role);
                    this.Hide();
                    MainForm mainForm = new MainForm(role, login, userId);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Невірний логін або пароль.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при вході: " + ex.Message);
            }
        }
        private string GetUserId(string login, string role)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "";
                if (role == "Teacher")
                {
                    query = "SELECT TeacherID FROM Teachers WHERE TeacherIdentifier = (SELECT TeacherIdentifier FROM Authorization WHERE Login = @login)";
                }
                else if (role == "Student")
                {
                    query = "SELECT StudentID FROM Students WHERE StudentIdentifier = (SELECT StudentIdentifier FROM Authorization WHERE Login = @login)";
                }
                else if (role == "Admin")
                {
                    return "Admin";
                }
                else
                {
                    throw new InvalidOperationException("Invalid role provided.");
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);
                return cmd.ExecuteScalar()?.ToString();
            }
        }

        private bool AuthenticateUser(string login, string password)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(1) FROM Authorization WHERE Login = @login AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", ComputeSha256Hash(password));
                return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
            }
        }
        private string GetUserRole(string login)
        {
            using (var conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Role FROM Authorization WHERE Login = @login", conn);
                cmd.Parameters.AddWithValue("@login", login);
                return cmd.ExecuteScalar()?.ToString();
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (System.Security.Cryptography.SHA256 sha256Hash = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при виході: " + ex.Message);
            }
        }
    }
}
