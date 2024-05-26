namespace SchoolManagementSystem
{
    partial class AddTeacherForm
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
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            subjectTextBox = new TextBox();
            qualificationTextBox = new TextBox();
            scheduleTextBox = new TextBox();
            addButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(178, 21);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 27);
            lastNameTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(178, 61);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(178, 101);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(200, 27);
            subjectTextBox.TabIndex = 2;
            // 
            // qualificationTextBox
            // 
            qualificationTextBox.Location = new Point(178, 141);
            qualificationTextBox.Name = "qualificationTextBox";
            qualificationTextBox.Size = new Size(200, 27);
            qualificationTextBox.TabIndex = 3;
            // 
            // scheduleTextBox
            // 
            scheduleTextBox.Location = new Point(178, 181);
            scheduleTextBox.Name = "scheduleTextBox";
            scheduleTextBox.Size = new Size(200, 27);
            scheduleTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(178, 221);
            addButton.Name = "addButton";
            addButton.Size = new Size(97, 37);
            addButton.TabIndex = 5;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(291, 221);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(87, 37);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddTeacherForm
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(scheduleTextBox);
            Controls.Add(qualificationTextBox);
            Controls.Add(subjectTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Name = "AddTeacherForm";
            Text = "Додавання вчителя";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox qualificationTextBox;
        private System.Windows.Forms.TextBox scheduleTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
