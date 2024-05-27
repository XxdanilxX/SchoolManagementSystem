namespace SchoolManagementSystem
{
    partial class MainForm
    {
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addStudentTab;
        private System.Windows.Forms.TabPage addTeacherTab;
        private System.Windows.Forms.TabPage addGradeTab;
        private System.Windows.Forms.TabPage addTaskTab;
        private System.Windows.Forms.TabPage manageClassesTab;

        // Add Student Controls
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.DataGridView studentsGridView; // DataGridView for Students

        // Add Teacher Controls
        private System.Windows.Forms.Label lastNameLabelTeacher;
        private System.Windows.Forms.Label firstNameLabelTeacher;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label qualificationLabel;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.TextBox lastNameTextBoxTeacher;
        private System.Windows.Forms.TextBox firstNameTextBoxTeacher;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox qualificationTextBox;
        private System.Windows.Forms.TextBox scheduleTextBox;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.DataGridView teachersGridView; // DataGridView for Teachers

        // Add Grade Controls
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label teacherIdLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label dateAssignedLabel;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox teacherIdTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.DateTimePicker dateAssignedPicker;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.DataGridView gradesGridView; // DataGridView for Grades

        // Add Task Controls
        private System.Windows.Forms.Label taskTypeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label completionDateLabel;
        private System.Windows.Forms.Label studentIdTaskLabel;
        private System.Windows.Forms.Label teacherIdTaskLabel;
        private System.Windows.Forms.TextBox taskTypeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox studentIdTaskTextBox;
        private System.Windows.Forms.TextBox teacherIdTaskTextBox;
        private System.Windows.Forms.DateTimePicker creationDatePicker;
        private System.Windows.Forms.DateTimePicker completionDatePicker;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.DataGridView tasksGridView; // DataGridView for Tasks

        // Manage Classes Controls
        private System.Windows.Forms.Label classListLabel;
        private System.Windows.Forms.TextBox classListTextBox;
        private System.Windows.Forms.Button manageClassesButton;
        private System.Windows.Forms.DataGridView classesGridView; // DataGridView for Classes

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            addStudentTab = new TabPage();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            birthDateLabel = new Label();
            classLabel = new Label();
            groupLabel = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            birthDatePicker = new DateTimePicker();
            classTextBox = new TextBox();
            groupTextBox = new TextBox();
            addStudentButton = new Button();
            studentsGridView = new DataGridView();
            addTeacherTab = new TabPage();
            lastNameLabelTeacher = new Label();
            firstNameLabelTeacher = new Label();
            subjectLabel = new Label();
            qualificationLabel = new Label();
            scheduleLabel = new Label();
            lastNameTextBoxTeacher = new TextBox();
            firstNameTextBoxTeacher = new TextBox();
            subjectTextBox = new TextBox();
            qualificationTextBox = new TextBox();
            scheduleTextBox = new TextBox();
            addTeacherButton = new Button();
            teachersGridView = new DataGridView();
            addGradeTab = new TabPage();
            studentIdLabel = new Label();
            teacherIdLabel = new Label();
            gradeLabel = new Label();
            dateAssignedLabel = new Label();
            studentIdTextBox = new TextBox();
            teacherIdTextBox = new TextBox();
            gradeTextBox = new TextBox();
            dateAssignedPicker = new DateTimePicker();
            addGradeButton = new Button();
            gradesGridView = new DataGridView();
            addTaskTab = new TabPage();
            taskTypeLabel = new Label();
            descriptionLabel = new Label();
            statusLabel = new Label();
            creationDateLabel = new Label();
            completionDateLabel = new Label();
            studentIdTaskLabel = new Label();
            teacherIdTaskLabel = new Label();
            taskTypeTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            statusTextBox = new TextBox();
            studentIdTaskTextBox = new TextBox();
            teacherIdTaskTextBox = new TextBox();
            creationDatePicker = new DateTimePicker();
            completionDatePicker = new DateTimePicker();
            addTaskButton = new Button();
            tasksGridView = new DataGridView();
            manageClassesTab = new TabPage();
            classListLabel = new Label();
            classListTextBox = new TextBox();
            manageClassesButton = new Button();
            classesGridView = new DataGridView();
            tabControl1.SuspendLayout();
            addStudentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).BeginInit();
            addTeacherTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersGridView).BeginInit();
            addGradeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradesGridView).BeginInit();
            addTaskTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tasksGridView).BeginInit();
            manageClassesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classesGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(addStudentTab);
            tabControl1.Controls.Add(addTeacherTab);
            tabControl1.Controls.Add(addGradeTab);
            tabControl1.Controls.Add(addTaskTab);
            tabControl1.Controls.Add(manageClassesTab);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(854, 555);
            tabControl1.TabIndex = 0;
            // 
            // addStudentTab
            // 
            addStudentTab.Controls.Add(lastNameLabel);
            addStudentTab.Controls.Add(firstNameLabel);
            addStudentTab.Controls.Add(birthDateLabel);
            addStudentTab.Controls.Add(classLabel);
            addStudentTab.Controls.Add(groupLabel);
            addStudentTab.Controls.Add(lastNameTextBox);
            addStudentTab.Controls.Add(firstNameTextBox);
            addStudentTab.Controls.Add(birthDatePicker);
            addStudentTab.Controls.Add(classTextBox);
            addStudentTab.Controls.Add(groupTextBox);
            addStudentTab.Controls.Add(addStudentButton);
            addStudentTab.Controls.Add(studentsGridView);
            addStudentTab.Location = new Point(4, 29);
            addStudentTab.Name = "addStudentTab";
            addStudentTab.Size = new Size(846, 522);
            addStudentTab.TabIndex = 0;
            addStudentTab.Text = "Управління учнями";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Location = new Point(38, 58);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 23);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Прізвище:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.Location = new Point(38, 95);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(100, 23);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "Ім'я:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.Location = new Point(38, 127);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(143, 24);
            birthDateLabel.TabIndex = 2;
            birthDateLabel.Text = "Дата народження:";
            // 
            // classLabel
            // 
            classLabel.Location = new Point(38, 164);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(100, 23);
            classLabel.TabIndex = 3;
            classLabel.Text = "Клас:";
            // 
            // groupLabel
            // 
            groupLabel.Location = new Point(38, 201);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(100, 23);
            groupLabel.TabIndex = 4;
            groupLabel.Text = "Група:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(218, 54);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 27);
            lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(218, 91);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 27);
            firstNameTextBox.TabIndex = 6;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(218, 124);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(200, 27);
            birthDatePicker.TabIndex = 7;
            // 
            // classTextBox
            // 
            classTextBox.Location = new Point(218, 160);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(200, 27);
            classTextBox.TabIndex = 8;
            // 
            // groupTextBox
            // 
            groupTextBox.Location = new Point(218, 197);
            groupTextBox.Name = "groupTextBox";
            groupTextBox.Size = new Size(200, 27);
            groupTextBox.TabIndex = 9;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(121, 272);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(240, 69);
            addStudentButton.TabIndex = 10;
            addStudentButton.Text = "Додати учня";
            // 
            // studentsGridView
            // 
            studentsGridView.ColumnHeadersHeight = 29;
            studentsGridView.Location = new Point(496, 3);
            studentsGridView.Name = "studentsGridView";
            studentsGridView.RowHeadersWidth = 51;
            studentsGridView.Size = new Size(349, 512);
            studentsGridView.TabIndex = 11;
            // 
            // addTeacherTab
            // 
            addTeacherTab.Controls.Add(lastNameLabelTeacher);
            addTeacherTab.Controls.Add(firstNameLabelTeacher);
            addTeacherTab.Controls.Add(subjectLabel);
            addTeacherTab.Controls.Add(qualificationLabel);
            addTeacherTab.Controls.Add(scheduleLabel);
            addTeacherTab.Controls.Add(lastNameTextBoxTeacher);
            addTeacherTab.Controls.Add(firstNameTextBoxTeacher);
            addTeacherTab.Controls.Add(subjectTextBox);
            addTeacherTab.Controls.Add(qualificationTextBox);
            addTeacherTab.Controls.Add(scheduleTextBox);
            addTeacherTab.Controls.Add(addTeacherButton);
            addTeacherTab.Controls.Add(teachersGridView);
            addTeacherTab.Location = new Point(4, 29);
            addTeacherTab.Name = "addTeacherTab";
            addTeacherTab.Size = new Size(846, 522);
            addTeacherTab.TabIndex = 1;
            addTeacherTab.Text = "Управління вчителями";
            // 
            // lastNameLabelTeacher
            // 
            lastNameLabelTeacher.Location = new Point(26, 27);
            lastNameLabelTeacher.Name = "lastNameLabelTeacher";
            lastNameLabelTeacher.Size = new Size(100, 23);
            lastNameLabelTeacher.TabIndex = 0;
            lastNameLabelTeacher.Text = "Прізвище:";
            // 
            // firstNameLabelTeacher
            // 
            firstNameLabelTeacher.Location = new Point(26, 78);
            firstNameLabelTeacher.Name = "firstNameLabelTeacher";
            firstNameLabelTeacher.Size = new Size(100, 23);
            firstNameLabelTeacher.TabIndex = 1;
            firstNameLabelTeacher.Text = "Ім'я:";
            // 
            // subjectLabel
            // 
            subjectLabel.Location = new Point(26, 120);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(100, 23);
            subjectLabel.TabIndex = 2;
            subjectLabel.Text = "Предмет:";
            // 
            // qualificationLabel
            // 
            qualificationLabel.Location = new Point(26, 168);
            qualificationLabel.Name = "qualificationLabel";
            qualificationLabel.Size = new Size(100, 23);
            qualificationLabel.TabIndex = 3;
            qualificationLabel.Text = "Кваліфікація:";
            // 
            // scheduleLabel
            // 
            scheduleLabel.Location = new Point(26, 219);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(100, 23);
            scheduleLabel.TabIndex = 4;
            scheduleLabel.Text = "Графік роботи:";
            // 
            // lastNameTextBoxTeacher
            // 
            lastNameTextBoxTeacher.Location = new Point(209, 23);
            lastNameTextBoxTeacher.Name = "lastNameTextBoxTeacher";
            lastNameTextBoxTeacher.Size = new Size(195, 27);
            lastNameTextBoxTeacher.TabIndex = 5;
            // 
            // firstNameTextBoxTeacher
            // 
            firstNameTextBoxTeacher.Location = new Point(209, 74);
            firstNameTextBoxTeacher.Name = "firstNameTextBoxTeacher";
            firstNameTextBoxTeacher.Size = new Size(195, 27);
            firstNameTextBoxTeacher.TabIndex = 6;
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(209, 116);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(195, 27);
            subjectTextBox.TabIndex = 7;
            // 
            // qualificationTextBox
            // 
            qualificationTextBox.Location = new Point(209, 164);
            qualificationTextBox.Name = "qualificationTextBox";
            qualificationTextBox.Size = new Size(195, 27);
            qualificationTextBox.TabIndex = 8;
            // 
            // scheduleTextBox
            // 
            scheduleTextBox.Location = new Point(209, 215);
            scheduleTextBox.Name = "scheduleTextBox";
            scheduleTextBox.Size = new Size(195, 27);
            scheduleTextBox.TabIndex = 9;
            // 
            // addTeacherButton
            // 
            addTeacherButton.Location = new Point(87, 286);
            addTeacherButton.Name = "addTeacherButton";
            addTeacherButton.Size = new Size(253, 99);
            addTeacherButton.TabIndex = 10;
            addTeacherButton.Text = "Додати";
            // 
            // teachersGridView
            // 
            teachersGridView.ColumnHeadersHeight = 29;
            teachersGridView.Location = new Point(482, 3);
            teachersGridView.Name = "teachersGridView";
            teachersGridView.RowHeadersWidth = 51;
            teachersGridView.Size = new Size(355, 512);
            teachersGridView.TabIndex = 11;
            // 
            // addGradeTab
            // 
            addGradeTab.Controls.Add(studentIdLabel);
            addGradeTab.Controls.Add(teacherIdLabel);
            addGradeTab.Controls.Add(gradeLabel);
            addGradeTab.Controls.Add(dateAssignedLabel);
            addGradeTab.Controls.Add(studentIdTextBox);
            addGradeTab.Controls.Add(teacherIdTextBox);
            addGradeTab.Controls.Add(gradeTextBox);
            addGradeTab.Controls.Add(dateAssignedPicker);
            addGradeTab.Controls.Add(addGradeButton);
            addGradeTab.Controls.Add(gradesGridView);
            addGradeTab.Location = new Point(4, 29);
            addGradeTab.Name = "addGradeTab";
            addGradeTab.Size = new Size(846, 522);
            addGradeTab.TabIndex = 2;
            addGradeTab.Text = "Оцінки";
            // 
            // studentIdLabel
            // 
            studentIdLabel.Location = new Point(39, 33);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new Size(100, 23);
            studentIdLabel.TabIndex = 0;
            studentIdLabel.Text = "ID учня:";
            // 
            // teacherIdLabel
            // 
            teacherIdLabel.Location = new Point(39, 66);
            teacherIdLabel.Name = "teacherIdLabel";
            teacherIdLabel.Size = new Size(100, 23);
            teacherIdLabel.TabIndex = 1;
            teacherIdLabel.Text = "ID вчителя:";
            // 
            // gradeLabel
            // 
            gradeLabel.Location = new Point(39, 99);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(100, 23);
            gradeLabel.TabIndex = 2;
            gradeLabel.Text = "Оцінка:";
            // 
            // dateAssignedLabel
            // 
            dateAssignedLabel.Location = new Point(39, 132);
            dateAssignedLabel.Name = "dateAssignedLabel";
            dateAssignedLabel.Size = new Size(100, 23);
            dateAssignedLabel.TabIndex = 3;
            dateAssignedLabel.Text = "Дата виставлення:";
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Location = new Point(224, 29);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.Size = new Size(195, 27);
            studentIdTextBox.TabIndex = 4;
            // 
            // teacherIdTextBox
            // 
            teacherIdTextBox.Location = new Point(224, 62);
            teacherIdTextBox.Name = "teacherIdTextBox";
            teacherIdTextBox.Size = new Size(195, 27);
            teacherIdTextBox.TabIndex = 5;
            // 
            // gradeTextBox
            // 
            gradeTextBox.Location = new Point(224, 95);
            gradeTextBox.Name = "gradeTextBox";
            gradeTextBox.Size = new Size(195, 27);
            gradeTextBox.TabIndex = 6;
            // 
            // dateAssignedPicker
            // 
            dateAssignedPicker.Location = new Point(224, 128);
            dateAssignedPicker.Name = "dateAssignedPicker";
            dateAssignedPicker.Size = new Size(195, 27);
            dateAssignedPicker.TabIndex = 7;
            // 
            // addGradeButton
            // 
            addGradeButton.Location = new Point(80, 185);
            addGradeButton.Name = "addGradeButton";
            addGradeButton.Size = new Size(271, 77);
            addGradeButton.TabIndex = 8;
            addGradeButton.Text = "Додати";
            // 
            // gradesGridView
            // 
            gradesGridView.ColumnHeadersHeight = 29;
            gradesGridView.Location = new Point(489, 3);
            gradesGridView.Name = "gradesGridView";
            gradesGridView.RowHeadersWidth = 51;
            gradesGridView.Size = new Size(354, 512);
            gradesGridView.TabIndex = 9;
            // 
            // addTaskTab
            // 
            addTaskTab.Controls.Add(taskTypeLabel);
            addTaskTab.Controls.Add(descriptionLabel);
            addTaskTab.Controls.Add(statusLabel);
            addTaskTab.Controls.Add(creationDateLabel);
            addTaskTab.Controls.Add(completionDateLabel);
            addTaskTab.Controls.Add(studentIdTaskLabel);
            addTaskTab.Controls.Add(teacherIdTaskLabel);
            addTaskTab.Controls.Add(taskTypeTextBox);
            addTaskTab.Controls.Add(descriptionTextBox);
            addTaskTab.Controls.Add(statusTextBox);
            addTaskTab.Controls.Add(studentIdTaskTextBox);
            addTaskTab.Controls.Add(teacherIdTaskTextBox);
            addTaskTab.Controls.Add(creationDatePicker);
            addTaskTab.Controls.Add(completionDatePicker);
            addTaskTab.Controls.Add(addTaskButton);
            addTaskTab.Controls.Add(tasksGridView);
            addTaskTab.Location = new Point(4, 29);
            addTaskTab.Name = "addTaskTab";
            addTaskTab.Size = new Size(846, 522);
            addTaskTab.TabIndex = 3;
            addTaskTab.Text = "Завдання";
            // 
            // taskTypeLabel
            // 
            taskTypeLabel.Location = new Point(28, 42);
            taskTypeLabel.Name = "taskTypeLabel";
            taskTypeLabel.Size = new Size(131, 23);
            taskTypeLabel.TabIndex = 0;
            taskTypeLabel.Text = "Тип завдання:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new Point(28, 75);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(100, 23);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Опис:";
            // 
            // statusLabel
            // 
            statusLabel.Location = new Point(28, 108);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(147, 23);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Статус:";
            // 
            // creationDateLabel
            // 
            creationDateLabel.Location = new Point(28, 141);
            creationDateLabel.Name = "creationDateLabel";
            creationDateLabel.Size = new Size(147, 23);
            creationDateLabel.TabIndex = 3;
            creationDateLabel.Text = "Дата створення:";
            // 
            // completionDateLabel
            // 
            completionDateLabel.Location = new Point(28, 174);
            completionDateLabel.Name = "completionDateLabel";
            completionDateLabel.Size = new Size(151, 23);
            completionDateLabel.TabIndex = 4;
            completionDateLabel.Text = "Дата завершення:";
            // 
            // studentIdTaskLabel
            // 
            studentIdTaskLabel.Location = new Point(28, 207);
            studentIdTaskLabel.Name = "studentIdTaskLabel";
            studentIdTaskLabel.Size = new Size(100, 23);
            studentIdTaskLabel.TabIndex = 5;
            studentIdTaskLabel.Text = "ID учня: ";
            // 
            // teacherIdTaskLabel
            // 
            teacherIdTaskLabel.Location = new Point(28, 240);
            teacherIdTaskLabel.Name = "teacherIdTaskLabel";
            teacherIdTaskLabel.Size = new Size(100, 23);
            teacherIdTaskLabel.TabIndex = 6;
            teacherIdTaskLabel.Text = "ID вчителя:";
            // 
            // taskTypeTextBox
            // 
            taskTypeTextBox.Location = new Point(209, 38);
            taskTypeTextBox.Name = "taskTypeTextBox";
            taskTypeTextBox.Size = new Size(200, 27);
            taskTypeTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(209, 71);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(200, 27);
            descriptionTextBox.TabIndex = 8;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(209, 104);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(200, 27);
            statusTextBox.TabIndex = 9;
            // 
            // studentIdTaskTextBox
            // 
            studentIdTaskTextBox.Location = new Point(209, 203);
            studentIdTaskTextBox.Name = "studentIdTaskTextBox";
            studentIdTaskTextBox.Size = new Size(200, 27);
            studentIdTaskTextBox.TabIndex = 10;
            // 
            // teacherIdTaskTextBox
            // 
            teacherIdTaskTextBox.Location = new Point(209, 236);
            teacherIdTaskTextBox.Name = "teacherIdTaskTextBox";
            teacherIdTaskTextBox.Size = new Size(200, 27);
            teacherIdTaskTextBox.TabIndex = 11;
            // 
            // creationDatePicker
            // 
            creationDatePicker.Location = new Point(209, 137);
            creationDatePicker.Name = "creationDatePicker";
            creationDatePicker.Size = new Size(200, 27);
            creationDatePicker.TabIndex = 12;
            // 
            // completionDatePicker
            // 
            completionDatePicker.Location = new Point(209, 170);
            completionDatePicker.Name = "completionDatePicker";
            completionDatePicker.Size = new Size(200, 27);
            completionDatePicker.TabIndex = 13;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(87, 292);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(267, 81);
            addTaskButton.TabIndex = 14;
            addTaskButton.Text = "Додати";
            // 
            // tasksGridView
            // 
            tasksGridView.ColumnHeadersHeight = 29;
            tasksGridView.Location = new Point(481, 3);
            tasksGridView.Name = "tasksGridView";
            tasksGridView.RowHeadersWidth = 51;
            tasksGridView.Size = new Size(362, 516);
            tasksGridView.TabIndex = 15;
            // 
            // manageClassesTab
            // 
            manageClassesTab.Controls.Add(classListLabel);
            manageClassesTab.Controls.Add(classListTextBox);
            manageClassesTab.Controls.Add(manageClassesButton);
            manageClassesTab.Controls.Add(classesGridView);
            manageClassesTab.Location = new Point(4, 29);
            manageClassesTab.Name = "manageClassesTab";
            manageClassesTab.Size = new Size(846, 522);
            manageClassesTab.TabIndex = 4;
            manageClassesTab.Text = "Класи";
            // 
            // classListLabel
            // 
            classListLabel.Location = new Point(23, 22);
            classListLabel.Name = "classListLabel";
            classListLabel.Size = new Size(163, 23);
            classListLabel.TabIndex = 0;
            classListLabel.Text = "Список класів:";
            // 
            // classListTextBox
            // 
            classListTextBox.Location = new Point(23, 48);
            classListTextBox.Multiline = true;
            classListTextBox.Name = "classListTextBox";
            classListTextBox.Size = new Size(444, 247);
            classListTextBox.TabIndex = 1;
            // 
            // manageClassesButton
            // 
            manageClassesButton.Location = new Point(75, 324);
            manageClassesButton.Name = "manageClassesButton";
            manageClassesButton.Size = new Size(318, 82);
            manageClassesButton.TabIndex = 2;
            manageClassesButton.Text = "Управляти класами";
            // 
            // classesGridView
            // 
            classesGridView.ColumnHeadersHeight = 29;
            classesGridView.Location = new Point(473, 3);
            classesGridView.Name = "classesGridView";
            classesGridView.RowHeadersWidth = 51;
            classesGridView.Size = new Size(364, 516);
            classesGridView.TabIndex = 3;
            // 
            // MainForm
            // 
            ClientSize = new Size(853, 556);
            Controls.Add(tabControl1);
            Name = "MainForm";
            tabControl1.ResumeLayout(false);
            addStudentTab.ResumeLayout(false);
            addStudentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).EndInit();
            addTeacherTab.ResumeLayout(false);
            addTeacherTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teachersGridView).EndInit();
            addGradeTab.ResumeLayout(false);
            addGradeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradesGridView).EndInit();
            addTaskTab.ResumeLayout(false);
            addTaskTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tasksGridView).EndInit();
            manageClassesTab.ResumeLayout(false);
            manageClassesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classesGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
