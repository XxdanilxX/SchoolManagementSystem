namespace SchoolManagementSystem
{
    partial class MainForm
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
            addStudentButton = new Button();
            addTeacherButton = new Button();
            addTaskButton = new Button();
            addGradeButton = new Button();
            manageClassesButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(12, 12);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(127, 51);
            addStudentButton.TabIndex = 0;
            addStudentButton.Text = "Додати учня";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // addTeacherButton
            // 
            addTeacherButton.Location = new Point(145, 12);
            addTeacherButton.Name = "addTeacherButton";
            addTeacherButton.Size = new Size(127, 51);
            addTeacherButton.TabIndex = 1;
            addTeacherButton.Text = "Додати вчителя";
            addTeacherButton.UseVisualStyleBackColor = true;
            addTeacherButton.Click += addTeacherButton_Click;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(278, 12);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(127, 51);
            addTaskButton.TabIndex = 2;
            addTaskButton.Text = "Додати завдання";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // addGradeButton
            // 
            addGradeButton.Location = new Point(411, 12);
            addGradeButton.Name = "addGradeButton";
            addGradeButton.Size = new Size(127, 51);
            addGradeButton.TabIndex = 3;
            addGradeButton.Text = "Додати оцінку";
            addGradeButton.UseVisualStyleBackColor = true;
            addGradeButton.Click += addGradeButton_Click;
            // 
            // manageClassesButton
            // 
            manageClassesButton.Location = new Point(544, 12);
            manageClassesButton.Name = "manageClassesButton";
            manageClassesButton.Size = new Size(127, 51);
            manageClassesButton.TabIndex = 4;
            manageClassesButton.Text = "Керування класами";
            manageClassesButton.UseVisualStyleBackColor = true;
            manageClassesButton.Click += manageClassesButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(677, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(127, 51);
            exitButton.TabIndex = 5;
            exitButton.Text = "Вихід";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(918, 500);
            Controls.Add(exitButton);
            Controls.Add(manageClassesButton);
            Controls.Add(addGradeButton);
            Controls.Add(addTaskButton);
            Controls.Add(addTeacherButton);
            Controls.Add(addStudentButton);
            Name = "MainForm";
            Text = "Електронний щоденник школяра";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.Button manageClassesButton;
        private System.Windows.Forms.Button exitButton;
    }
}
