using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ManageClassesForm : Form
    {
        public ManageClassesForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            // Add class logic
        }

        private void removeClassButton_Click(object sender, EventArgs e)
        {
            // Remove class logic
        }
    }
}
