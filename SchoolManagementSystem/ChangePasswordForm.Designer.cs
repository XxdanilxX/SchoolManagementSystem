namespace SchoolManagementSystem
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            newPasswordLabel = new Label();
            confirmNewPasswordLabel = new Label();
            newPasswordTextBox = new TextBox();
            confirmNewPasswordTextBox = new TextBox();
            changePasswordButton = new Button();
            SuspendLayout();
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(12, 15);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(113, 20);
            newPasswordLabel.TabIndex = 0;
            newPasswordLabel.Text = "Новий пароль:";
            // 
            // confirmNewPasswordLabel
            // 
            confirmNewPasswordLabel.AutoSize = true;
            confirmNewPasswordLabel.Location = new Point(12, 55);
            confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
            confirmNewPasswordLabel.Size = new Size(195, 20);
            confirmNewPasswordLabel.TabIndex = 1;
            confirmNewPasswordLabel.Text = "Підтвердіть новий пароль:";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(231, 15);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.Size = new Size(200, 27);
            newPasswordTextBox.TabIndex = 2;
            // 
            // confirmNewPasswordTextBox
            // 
            confirmNewPasswordTextBox.Location = new Point(231, 48);
            confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            confirmNewPasswordTextBox.PasswordChar = '*';
            confirmNewPasswordTextBox.Size = new Size(200, 27);
            confirmNewPasswordTextBox.TabIndex = 3;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(231, 93);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(200, 51);
            changePasswordButton.TabIndex = 4;
            changePasswordButton.Text = "Змінити пароль";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 156);
            Controls.Add(changePasswordButton);
            Controls.Add(confirmNewPasswordTextBox);
            Controls.Add(newPasswordTextBox);
            Controls.Add(confirmNewPasswordLabel);
            Controls.Add(newPasswordLabel);
            Name = "ChangePasswordForm";
            Text = "Зміна паролю";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label confirmNewPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.Button changePasswordButton;
    }
}
