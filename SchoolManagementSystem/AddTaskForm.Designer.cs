namespace SchoolManagementSystem
{
    partial class AddTaskForm
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
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.creationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.completionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.teacherIDTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(150, 30);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(200, 20);
            this.typeTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(150, 70);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(150, 110);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 2;
            // 
            // creationDateTimePicker
            // 
            this.creationDateTimePicker.Location = new System.Drawing.Point(150, 150);
            this.creationDateTimePicker.Name = "creationDateTimePicker";
            this.creationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationDateTimePicker.TabIndex = 3;
            // 
            // completionDateTimePicker
            // 
            this.completionDateTimePicker.Location = new System.Drawing.Point(150, 190);
            this.completionDateTimePicker.Name = "completionDateTimePicker";
            this.completionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.completionDateTimePicker.TabIndex = 4;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(150, 230);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentIDTextBox.TabIndex = 5;
            // 
            // teacherIDTextBox
            // 
            this.teacherIDTextBox.Location = new System.Drawing.Point(150, 270);
            this.teacherIDTextBox.Name = "teacherIDTextBox";
            this.teacherIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacherIDTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(150, 310);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(275, 310);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddTaskForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.teacherIDTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.completionDateTimePicker);
            this.Controls.Add(this.creationDateTimePicker);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Name = "AddTaskForm";
            this.Text = "Додавання завдання";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.DateTimePicker creationDateTimePicker;
        private System.Windows.Forms.DateTimePicker completionDateTimePicker;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox teacherIDTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
