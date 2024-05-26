namespace SchoolManagementSystem
{
    partial class ManageClassesForm
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
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.addClassButton = new System.Windows.Forms.Button();
            this.removeClassButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Location = new System.Drawing.Point(30, 30);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(200, 290);
            this.classesListBox.TabIndex = 0;
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(250, 30);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(100, 30);
            this.addClassButton.TabIndex = 1;
            this.addClassButton.Text = "Додати клас";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // removeClassButton
            // 
            this.removeClassButton.Location = new System.Drawing.Point(250, 80);
            this.removeClassButton.Name = "removeClassButton";
            this.removeClassButton.Size = new System.Drawing.Size(100, 30);
            this.removeClassButton.TabIndex = 2;
            this.removeClassButton.Text = "Видалити клас";
            this.removeClassButton.UseVisualStyleBackColor = true;
            this.removeClassButton.Click += new System.EventHandler(this.removeClassButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(250, 130);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ManageClassesForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeClassButton);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.classesListBox);
            this.Name = "ManageClassesForm";
            this.Text = "Керування класами";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Button removeClassButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
