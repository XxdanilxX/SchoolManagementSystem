using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    public partial class ChangePasswordForm : Form
    {
        private string userLogin;

        public ChangePasswordForm(string userLogin)
        {
            InitializeComponent();
            this.userLogin = userLogin;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (newPasswordTextBox.Text == confirmNewPasswordTextBox.Text)
                {
                    using (var conn = DBUtils.GetDBConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE Authorization SET Password=@Password WHERE Login=@UserLogin", conn);
                        cmd.Parameters.AddWithValue("@Password", ComputeSha256Hash(newPasswordTextBox.Text));
                        cmd.Parameters.AddWithValue("@UserLogin", userLogin);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Пароль успішно змінено.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Паролі не співпадають. Будь ласка, спробуйте ще раз.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при зміні паролю: " + ex.Message);
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
