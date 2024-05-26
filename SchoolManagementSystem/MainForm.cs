using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            addTeacherForm.ShowDialog();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            AddGradeForm addGradeForm = new AddGradeForm();
            addGradeForm.ShowDialog();
        }

        private void manageClassesButton_Click(object sender, EventArgs e)
        {
            ManageClassesForm manageClassesForm = new ManageClassesForm();
            manageClassesForm.ShowDialog();
        }
    }
}
