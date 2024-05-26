using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddGradeForm : Form
    {
        public AddGradeForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Add grade logic
        }
    }
}
