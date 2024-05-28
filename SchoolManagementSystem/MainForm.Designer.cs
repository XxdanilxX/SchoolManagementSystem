namespace SchoolManagementSystem
{
    partial class MainForm
    {
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addStudentTab;
        private System.Windows.Forms.TabPage addTeacherTab;
        private System.Windows.Forms.TabPage addGradeTab;
        private System.Windows.Forms.TabPage addTaskTab;

        // Add Student Controls
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox identifierTextBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.Label filterStudentsLabel;
        private System.Windows.Forms.TextBox filterStudentsTextBox;
        private System.Windows.Forms.Button filterStudentsButton;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button updateStudentButton;

        // Add Teacher Controls
        private System.Windows.Forms.Label lastNameLabelTeacher;
        private System.Windows.Forms.Label firstNameLabelTeacher;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label qualificationLabel;
        private System.Windows.Forms.Label identifierLabelTeacher;
        private System.Windows.Forms.TextBox lastNameTextBoxTeacher;
        private System.Windows.Forms.TextBox firstNameTextBoxTeacher;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox qualificationTextBox;
        private System.Windows.Forms.TextBox identifierTextBoxTeacher;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.DataGridView teachersGridView;
        private System.Windows.Forms.Label filterTeachersLabel;
        private System.Windows.Forms.TextBox filterTeachersTextBox;
        private System.Windows.Forms.Button filterTeachersButton;
        private System.Windows.Forms.Button deleteTeacherButton;
        private System.Windows.Forms.Button updateTeacherButton;

        // Add Grade Controls

        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentClassLabel;
        private System.Windows.Forms.Label studentGroupLabel;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label teacherIdLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label dateAssignedLabel;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentClassTextBox;
        private System.Windows.Forms.TextBox studentGroupTextBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox teacherIdTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.DateTimePicker dateAssignedPicker;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.DataGridView gradesGridView;
        private System.Windows.Forms.TextBox filterGradesTextBox;
        private System.Windows.Forms.Button filterGradesButton;
        private System.Windows.Forms.Button deleteGradeButton;
        private System.Windows.Forms.Button updateGradeButton;

        // Add Task Controls
        private System.Windows.Forms.Label taskTypeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label completionDateLabel;
        private System.Windows.Forms.Label teacherIdTaskLabel;
        private System.Windows.Forms.Label classLabelTask;
        private System.Windows.Forms.Label groupLabelTask;
        private System.Windows.Forms.TextBox taskTypeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox teacherIdTaskTextBox;
        private System.Windows.Forms.TextBox classTextBoxTask;
        private System.Windows.Forms.TextBox groupTextBoxTask;
        private System.Windows.Forms.DateTimePicker creationDatePicker;
        private System.Windows.Forms.DateTimePicker completionDatePicker;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.DataGridView tasksGridView;
        private System.Windows.Forms.TextBox filterTasksTextBox;
        private System.Windows.Forms.Button filterTasksButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button updateTaskButton;

        private void InitializeComponent()
        {
            studentNameLabel = new Label(); // Новий лейбл для імені студента
            studentClassLabel = new Label(); // Новий лейбл для класу студента
            studentGroupLabel = new Label(); // Новий лейбл для групи студента
            teacherNameLabel = new Label(); // Новий лейбл для імені вчителя
            studentNameTextBox = new TextBox(); // Нове текстове поле для імені студента
            studentClassTextBox = new TextBox(); // Нове текстове поле для класу студента
            studentGroupTextBox = new TextBox(); // Нове текстове поле для групи студента
            teacherNameTextBox = new TextBox(); // Нове текстове поле для імені вчителя
            tabControl1 = new TabControl();
            addStudentTab = new TabPage();
            filterStudentsLabel = new Label();
            filterStudentsTextBox = new TextBox();
            filterStudentsButton = new Button();
            deleteStudentButton = new Button();
            updateStudentButton = new Button();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            birthDateLabel = new Label();
            classLabel = new Label();
            groupLabel = new Label();
            identifierLabel = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            birthDatePicker = new DateTimePicker();
            classTextBox = new TextBox();
            groupTextBox = new TextBox();
            identifierTextBox = new TextBox();
            addStudentButton = new Button();
            studentsGridView = new DataGridView();
            addTeacherTab = new TabPage();
            filterTeachersLabel = new Label();
            filterTeachersTextBox = new TextBox();
            filterTeachersButton = new Button();
            deleteTeacherButton = new Button();
            updateTeacherButton = new Button();
            lastNameLabelTeacher = new Label();
            firstNameLabelTeacher = new Label();
            subjectLabel = new Label();
            qualificationLabel = new Label();
            identifierLabelTeacher = new Label();
            lastNameTextBoxTeacher = new TextBox();
            firstNameTextBoxTeacher = new TextBox();
            subjectTextBox = new TextBox();
            qualificationTextBox = new TextBox();
            identifierTextBoxTeacher = new TextBox();
            addTeacherButton = new Button();
            teachersGridView = new DataGridView();
            addGradeTab = new TabPage();
            studentIdLabel = new Label();
            studentNameLabel = new Label();
            studentClassLabel = new Label();
            studentGroupLabel = new Label();
            teacherNameLabel = new Label();
            teacherIdLabel = new Label();
            gradeLabel = new Label();
            dateAssignedLabel = new Label();
            studentIdTextBox = new TextBox();
            studentNameTextBox = new TextBox();
            studentClassTextBox = new TextBox();
            studentGroupTextBox = new TextBox();
            teacherNameTextBox = new TextBox();
            teacherIdTextBox = new TextBox();
            gradeTextBox = new TextBox();
            dateAssignedPicker = new DateTimePicker();
            addGradeButton = new Button();
            gradesGridView = new DataGridView();
            filterGradesTextBox = new TextBox();
            filterGradesButton = new Button();
            deleteGradeButton = new Button();
            updateGradeButton = new Button();
            addTaskTab = new TabPage();
            taskTypeLabel = new Label();
            descriptionLabel = new Label();
            statusLabel = new Label();
            creationDateLabel = new Label();
            completionDateLabel = new Label();
            teacherIdTaskLabel = new Label();
            classLabelTask = new Label();
            groupLabelTask = new Label();
            taskTypeTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            statusTextBox = new TextBox();
            teacherIdTaskTextBox = new TextBox();
            classTextBoxTask = new TextBox();
            groupTextBoxTask = new TextBox();
            creationDatePicker = new DateTimePicker();
            completionDatePicker = new DateTimePicker();
            addTaskButton = new Button();
            tasksGridView = new DataGridView();
            filterTasksTextBox = new TextBox();
            filterTasksButton = new Button();
            deleteTaskButton = new Button();
            updateTaskButton = new Button();
            tabControl1.SuspendLayout();
            addStudentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).BeginInit();
            addTeacherTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersGridView).BeginInit();
            addGradeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradesGridView).BeginInit();
            addTaskTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tasksGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(addStudentTab);
            tabControl1.Controls.Add(addTeacherTab);
            tabControl1.Controls.Add(addGradeTab);
            tabControl1.Controls.Add(addTaskTab);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(854, 555);
            tabControl1.TabIndex = 0;
            // 
            // addStudentTab
            // 
            addStudentTab.Controls.Add(filterStudentsLabel);
            addStudentTab.Controls.Add(filterStudentsTextBox);
            addStudentTab.Controls.Add(filterStudentsButton);
            addStudentTab.Controls.Add(deleteStudentButton);
            addStudentTab.Controls.Add(updateStudentButton);
            addStudentTab.Controls.Add(lastNameLabel);
            addStudentTab.Controls.Add(firstNameLabel);
            addStudentTab.Controls.Add(birthDateLabel);
            addStudentTab.Controls.Add(classLabel);
            addStudentTab.Controls.Add(groupLabel);
            addStudentTab.Controls.Add(identifierLabel);
            addStudentTab.Controls.Add(lastNameTextBox);
            addStudentTab.Controls.Add(firstNameTextBox);
            addStudentTab.Controls.Add(birthDatePicker);
            addStudentTab.Controls.Add(classTextBox);
            addStudentTab.Controls.Add(groupTextBox);
            addStudentTab.Controls.Add(identifierTextBox);
            addStudentTab.Controls.Add(addStudentButton);
            addStudentTab.Controls.Add(studentsGridView);
            addStudentTab.Location = new Point(4, 29);
            addStudentTab.Name = "addStudentTab";
            addStudentTab.Size = new Size(846, 522);
            addStudentTab.TabIndex = 0;
            addStudentTab.Text = "Управління учнями";
            // 
            // filterStudentsLabel
            // 
            // Налаштування для нових лейблів та текстових полів
            studentNameLabel.Location = new Point(39, 66);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(100, 23);
            studentNameLabel.TabIndex = 14;
            studentNameLabel.Text = "Ім'я учня:";

            studentClassLabel.Location = new Point(39, 99);
            studentClassLabel.Name = "studentClassLabel";
            studentClassLabel.Size = new Size(100, 23);
            studentClassLabel.TabIndex = 15;
            studentClassLabel.Text = "Клас:";

            studentGroupLabel.Location = new Point(39, 132);
            studentGroupLabel.Name = "studentGroupLabel";
            studentGroupLabel.Size = new Size(100, 23);
            studentGroupLabel.TabIndex = 16;
            studentGroupLabel.Text = "Група:";

            teacherNameLabel.Location = new Point(39, 165);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new Size(100, 23);
            teacherNameLabel.TabIndex = 17;
            teacherNameLabel.Text = "Ім'я вчителя:";

            studentNameTextBox.Location = new Point(224, 62);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(195, 27);
            studentNameTextBox.TabIndex = 18;
            studentNameTextBox.ReadOnly = true;

            studentClassTextBox.Location = new Point(224, 95);
            studentClassTextBox.Name = "studentClassTextBox";
            studentClassTextBox.Size = new Size(195, 27);
            studentClassTextBox.TabIndex = 19;
            studentClassTextBox.ReadOnly = true;

            studentGroupTextBox.Location = new Point(224, 128);
            studentGroupTextBox.Name = "studentGroupTextBox";
            studentGroupTextBox.Size = new Size(195, 27);
            studentGroupTextBox.TabIndex = 20;
            studentGroupTextBox.ReadOnly = true;

            teacherNameTextBox.Location = new Point(224, 161);
            teacherNameTextBox.Name = "teacherNameTextBox";
            teacherNameTextBox.Size = new Size(195, 27);
            teacherNameTextBox.TabIndex = 21;
            teacherNameTextBox.ReadOnly = true;

            // Додавання контролів на форму
            addGradeTab.Controls.Add(studentNameLabel);
            addGradeTab.Controls.Add(studentClassLabel);
            addGradeTab.Controls.Add(studentGroupLabel);
            addGradeTab.Controls.Add(teacherNameLabel);
            addGradeTab.Controls.Add(studentNameTextBox);
            addGradeTab.Controls.Add(studentClassTextBox);
            addGradeTab.Controls.Add(studentGroupTextBox);
            addGradeTab.Controls.Add(teacherNameTextBox);

            filterStudentsLabel.Location = new Point(565, 35);
            filterStudentsLabel.Name = "filterStudentsLabel";
            filterStudentsLabel.Size = new Size(132, 23);
            filterStudentsLabel.TabIndex = 0;
            filterStudentsLabel.Text = "Додайте фільтр:";
            // 
            // filterStudentsTextBox
            // 
            filterStudentsTextBox.Location = new Point(565, 61);
            filterStudentsTextBox.Name = "filterStudentsTextBox";
            filterStudentsTextBox.Size = new Size(238, 27);
            filterStudentsTextBox.TabIndex = 1;
            // 
            // filterStudentsButton
            // 
            filterStudentsButton.Location = new Point(443, 54);
            filterStudentsButton.Name = "filterStudentsButton";
            filterStudentsButton.Size = new Size(116, 40);
            filterStudentsButton.TabIndex = 2;
            filterStudentsButton.Text = "Фільтрувати";
            filterStudentsButton.Click += filterStudentsButton_Click;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Location = new Point(565, 100);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(116, 46);
            deleteStudentButton.TabIndex = 3;
            deleteStudentButton.Text = "Видалити";
            deleteStudentButton.Click += deleteStudentButton_Click;
            // 
            // updateStudentButton
            // 
            updateStudentButton.Location = new Point(687, 100);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(116, 46);
            updateStudentButton.TabIndex = 4;
            updateStudentButton.Text = "Оновити";
            updateStudentButton.Click += updateStudentButton_Click;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Location = new Point(35, 35);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 23);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Прізвище:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.Location = new Point(35, 72);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(100, 23);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "Ім'я:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.Location = new Point(35, 104);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(143, 24);
            birthDateLabel.TabIndex = 2;
            birthDateLabel.Text = "Дата народження:";
            // 
            // classLabel
            // 
            classLabel.Location = new Point(35, 141);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(100, 23);
            classLabel.TabIndex = 3;
            classLabel.Text = "Клас:";
            // 
            // groupLabel
            // 
            groupLabel.Location = new Point(35, 178);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(100, 23);
            groupLabel.TabIndex = 4;
            groupLabel.Text = "Група:";
            // 
            // identifierLabel
            // 
            identifierLabel.Location = new Point(35, 215);
            identifierLabel.Name = "identifierLabel";
            identifierLabel.Size = new Size(113, 23);
            identifierLabel.TabIndex = 4;
            identifierLabel.Text = "Ідентифікатор:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(215, 31);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 27);
            lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(215, 68);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 27);
            firstNameTextBox.TabIndex = 6;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(215, 101);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(200, 27);
            birthDatePicker.TabIndex = 7;
            // 
            // classTextBox
            // 
            classTextBox.Location = new Point(215, 137);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(200, 27);
            classTextBox.TabIndex = 8;
            // 
            // groupTextBox
            // 
            groupTextBox.Location = new Point(215, 174);
            groupTextBox.Name = "groupTextBox";
            groupTextBox.Size = new Size(200, 27);
            groupTextBox.TabIndex = 9;
            // 
            // identifierTextBox
            // 
            identifierTextBox.Location = new Point(215, 212);
            identifierTextBox.Name = "identifierTextBox";
            identifierTextBox.Size = new Size(200, 27);
            identifierTextBox.TabIndex = 9;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(443, 100);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(116, 46);
            addStudentButton.TabIndex = 10;
            addStudentButton.Text = "Додати учня";
            addStudentButton.Click += addStudentButton_Click;
            // 
            // studentsGridView
            // 
            studentsGridView.ColumnHeadersHeight = 29;
            studentsGridView.Location = new Point(8, 246);
            studentsGridView.Name = "studentsGridView";
            studentsGridView.RowHeadersWidth = 51;
            studentsGridView.Size = new Size(837, 269);
            studentsGridView.TabIndex = 11;
            studentsGridView.CellDoubleClick += studentsGridView_CellDoubleClick;
            // 
            // addTeacherTab
            // 
            addTeacherTab.Controls.Add(filterTeachersLabel);
            addTeacherTab.Controls.Add(filterTeachersTextBox);
            addTeacherTab.Controls.Add(filterTeachersButton);
            addTeacherTab.Controls.Add(deleteTeacherButton);
            addTeacherTab.Controls.Add(updateTeacherButton);
            addTeacherTab.Controls.Add(lastNameLabelTeacher);
            addTeacherTab.Controls.Add(firstNameLabelTeacher);
            addTeacherTab.Controls.Add(subjectLabel);
            addTeacherTab.Controls.Add(qualificationLabel);
            addTeacherTab.Controls.Add(identifierLabelTeacher);
            addTeacherTab.Controls.Add(lastNameTextBoxTeacher);
            addTeacherTab.Controls.Add(firstNameTextBoxTeacher);
            addTeacherTab.Controls.Add(subjectTextBox);
            addTeacherTab.Controls.Add(qualificationTextBox);
            addTeacherTab.Controls.Add(identifierTextBoxTeacher);
            addTeacherTab.Controls.Add(addTeacherButton);
            addTeacherTab.Controls.Add(teachersGridView);
            addTeacherTab.Location = new Point(4, 29);
            addTeacherTab.Name = "addTeacherTab";
            addTeacherTab.Size = new Size(846, 522);
            addTeacherTab.TabIndex = 1;
            addTeacherTab.Text = "Управління вчителями";
            // 
            // filterTeachersLabel
            // 
            filterTeachersLabel.Location = new Point(563, 25);
            filterTeachersLabel.Name = "filterTeachersLabel";
            filterTeachersLabel.Size = new Size(123, 23);
            filterTeachersLabel.TabIndex = 0;
            filterTeachersLabel.Text = "Додайте фільтр:";
            // 
            // filterTeachersTextBox
            // 
            filterTeachersTextBox.Location = new Point(563, 51);
            filterTeachersTextBox.Name = "filterTeachersTextBox";
            filterTeachersTextBox.Size = new Size(258, 27);
            filterTeachersTextBox.TabIndex = 1;
            // 
            // filterTeachersButton
            // 
            filterTeachersButton.Location = new Point(431, 41);
            filterTeachersButton.Name = "filterTeachersButton";
            filterTeachersButton.Size = new Size(126, 47);
            filterTeachersButton.TabIndex = 2;
            filterTeachersButton.Text = "Фільтрувати";
            filterTeachersButton.Click += filterTeachersButton_Click;
            // 
            // deleteTeacherButton
            // 
            deleteTeacherButton.Location = new Point(563, 94);
            deleteTeacherButton.Name = "deleteTeacherButton";
            deleteTeacherButton.Size = new Size(126, 51);
            deleteTeacherButton.TabIndex = 3;
            deleteTeacherButton.Text = "Видалити";
            deleteTeacherButton.Click += deleteTeacherButton_Click;
            // 
            // updateTeacherButton
            // 
            updateTeacherButton.Location = new Point(695, 94);
            updateTeacherButton.Name = "updateTeacherButton";
            updateTeacherButton.Size = new Size(126, 51);
            updateTeacherButton.TabIndex = 4;
            updateTeacherButton.Text = "Оновити";
            updateTeacherButton.Click += updateTeacherButton_Click;
            // 
            // lastNameLabelTeacher
            // 
            lastNameLabelTeacher.Location = new Point(26, 45);
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
            subjectLabel.Location = new Point(26, 111);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(100, 23);
            subjectLabel.TabIndex = 2;
            subjectLabel.Text = "Предмет:";
            // 
            // qualificationLabel
            // 
            qualificationLabel.Location = new Point(26, 144);
            qualificationLabel.Name = "qualificationLabel";
            qualificationLabel.Size = new Size(100, 23);
            qualificationLabel.TabIndex = 3;
            qualificationLabel.Text = "Кваліфікація:";
            // 
            // identifierLabelTeacher
            // 
            identifierLabelTeacher.Location = new Point(26, 177);
            identifierLabelTeacher.Name = "identifierLabelTeacher";
            identifierLabelTeacher.Size = new Size(116, 23);
            identifierLabelTeacher.TabIndex = 4;
            identifierLabelTeacher.Text = "Ідентифікатор:";
            // 
            // lastNameTextBoxTeacher
            // 
            lastNameTextBoxTeacher.Location = new Point(209, 41);
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
            subjectTextBox.Location = new Point(209, 107);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(195, 27);
            subjectTextBox.TabIndex = 7;
            // 
            // qualificationTextBox
            // 
            qualificationTextBox.Location = new Point(209, 140);
            qualificationTextBox.Name = "qualificationTextBox";
            qualificationTextBox.Size = new Size(195, 27);
            qualificationTextBox.TabIndex = 8;
            // 
            // identifierTextBoxTeacher
            // 
            identifierTextBoxTeacher.Location = new Point(209, 173);
            identifierTextBoxTeacher.Name = "identifierTextBoxTeacher";
            identifierTextBoxTeacher.Size = new Size(195, 27);
            identifierTextBoxTeacher.TabIndex = 9;
            // 
            // addTeacherButton
            // 
            addTeacherButton.Location = new Point(431, 94);
            addTeacherButton.Name = "addTeacherButton";
            addTeacherButton.Size = new Size(126, 51);
            addTeacherButton.TabIndex = 10;
            addTeacherButton.Text = "Додати";
            addTeacherButton.Click += addTeacherButton_Click;
            // 
            // teachersGridView
            // 
            teachersGridView.ColumnHeadersHeight = 29;
            teachersGridView.Location = new Point(8, 221);
            teachersGridView.Name = "teachersGridView";
            teachersGridView.RowHeadersWidth = 51;
            teachersGridView.Size = new Size(829, 301);
            teachersGridView.TabIndex = 11;
            teachersGridView.CellDoubleClick += teachersGridView_CellDoubleClick;
            // 
            // addGradeTab
            // 
            addGradeTab.Controls.Add(studentIdLabel);
            addGradeTab.Controls.Add(studentNameLabel);
            addGradeTab.Controls.Add(studentClassLabel);
            addGradeTab.Controls.Add(studentGroupLabel);
            addGradeTab.Controls.Add(teacherNameLabel);
            addGradeTab.Controls.Add(teacherIdLabel);
            addGradeTab.Controls.Add(gradeLabel);
            addGradeTab.Controls.Add(dateAssignedLabel);
            addGradeTab.Controls.Add(studentIdTextBox);
            addGradeTab.Controls.Add(studentNameTextBox);
            addGradeTab.Controls.Add(studentClassTextBox);
            addGradeTab.Controls.Add(studentGroupTextBox);
            addGradeTab.Controls.Add(teacherNameTextBox);
            addGradeTab.Controls.Add(teacherIdTextBox);
            addGradeTab.Controls.Add(gradeTextBox);
            addGradeTab.Controls.Add(dateAssignedPicker);
            addGradeTab.Controls.Add(addGradeButton);
            addGradeTab.Controls.Add(gradesGridView);
            addGradeTab.Controls.Add(filterGradesTextBox);
            addGradeTab.Controls.Add(filterGradesButton);
            addGradeTab.Controls.Add(deleteGradeButton);
            addGradeTab.Controls.Add(updateGradeButton);
            addGradeTab.Location = new Point(4, 29);
            addGradeTab.Name = "addGradeTab";
            addGradeTab.Size = new Size(846, 522);
            addGradeTab.TabIndex = 2;
            addGradeTab.Text = "Виставлення оцінки";
            // 
            // studentIdLabel
            // 
            studentIdLabel.Location = new Point(39, 33);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new Size(100, 23);
            studentIdLabel.TabIndex = 0;
            studentIdLabel.Text = "ID учня:";
            // 
            // studentNameLabel
            // 
            studentNameLabel.Location = new Point(39, 66);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(100, 23);
            studentNameLabel.TabIndex = 14;
            studentNameLabel.Text = "Ім'я учня:";
            // 
            // studentClassLabel
            // 
            studentClassLabel.Location = new Point(39, 99);
            studentClassLabel.Name = "studentClassLabel";
            studentClassLabel.Size = new Size(100, 23);
            studentClassLabel.TabIndex = 15;
            studentClassLabel.Text = "Клас:";
            // 
            // studentGroupLabel
            // 
            studentGroupLabel.Location = new Point(39, 132);
            studentGroupLabel.Name = "studentGroupLabel";
            studentGroupLabel.Size = new Size(100, 23);
            studentGroupLabel.TabIndex = 16;
            studentGroupLabel.Text = "Група:";
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.Location = new Point(39, 165);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new Size(100, 23);
            teacherNameLabel.TabIndex = 17;
            teacherNameLabel.Text = "Ім'я вчителя:";
            // 
            // teacherIdLabel
            // 
            teacherIdLabel.Location = new Point(39, 198);
            teacherIdLabel.Name = "teacherIdLabel";
            teacherIdLabel.Size = new Size(100, 23);
            teacherIdLabel.TabIndex = 1;
            teacherIdLabel.Text = "ID вчителя:";
            // 
            // gradeLabel
            // 
            gradeLabel.Location = new Point(39, 231);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(100, 23);
            gradeLabel.TabIndex = 2;
            gradeLabel.Text = "Оцінка:";
            // 
            // dateAssignedLabel
            // 
            dateAssignedLabel.Location = new Point(39, 264);
            dateAssignedLabel.Name = "dateAssignedLabel";
            dateAssignedLabel.Size = new Size(135, 23);
            dateAssignedLabel.TabIndex = 3;
            dateAssignedLabel.Text = "Дата виставлення:";
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Location = new Point(224, 29);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.Size = new Size(195, 27);
            studentIdTextBox.TabIndex = 4;
            studentIdTextBox.Leave += studentIdTextBox_Leave;
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(224, 62);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(195, 27);
            studentNameTextBox.TabIndex = 18;
            // 
            // studentClassTextBox
            // 
            studentClassTextBox.Location = new Point(224, 95);
            studentClassTextBox.Name = "studentClassTextBox";
            studentClassTextBox.Size = new Size(195, 27);
            studentClassTextBox.TabIndex = 19;
            // 
            // studentGroupTextBox
            // 
            studentGroupTextBox.Location = new Point(224, 128);
            studentGroupTextBox.Name = "studentGroupTextBox";
            studentGroupTextBox.Size = new Size(195, 27);
            studentGroupTextBox.TabIndex = 20;
            // 
            // teacherNameTextBox
            // 
            teacherNameTextBox.Location = new Point(224, 161);
            teacherNameTextBox.Name = "teacherNameTextBox";
            teacherNameTextBox.Size = new Size(195, 27);
            teacherNameTextBox.TabIndex = 21;
            // 
            // teacherIdTextBox
            // 
            teacherIdTextBox.Location = new Point(224, 194);
            teacherIdTextBox.Name = "teacherIdTextBox";
            teacherIdTextBox.Size = new Size(195, 27);
            teacherIdTextBox.TabIndex = 5;
            teacherIdTextBox.Leave += teacherIdTextBox_Leave;
            // 
            // gradeTextBox
            // 
            gradeTextBox.Location = new Point(224, 227);
            gradeTextBox.Name = "gradeTextBox";
            gradeTextBox.Size = new Size(195, 27);
            gradeTextBox.TabIndex = 6;
            // 
            // dateAssignedPicker
            // 
            dateAssignedPicker.Location = new Point(224, 260);
            dateAssignedPicker.Name = "dateAssignedPicker";
            dateAssignedPicker.Size = new Size(195, 27);
            dateAssignedPicker.TabIndex = 7;
            // 
            // addGradeButton
            // 
            addGradeButton.Location = new Point(455, 78);
            addGradeButton.Name = "addGradeButton";
            addGradeButton.Size = new Size(123, 44);
            addGradeButton.TabIndex = 8;
            addGradeButton.Text = "Додати";
            addGradeButton.Click += addGradeButton_Click;
            // 
            // gradesGridView
            // 
            gradesGridView.ColumnHeadersHeight = 29;
            gradesGridView.Location = new Point(3, 309);
            gradesGridView.Name = "gradesGridView";
            gradesGridView.RowHeadersWidth = 51;
            gradesGridView.Size = new Size(835, 206);
            gradesGridView.TabIndex = 9;
            gradesGridView.CellDoubleClick += gradesGridView_CellDoubleClick;
            // 
            // filterGradesTextBox
            // 
            filterGradesTextBox.Location = new Point(584, 37);
            filterGradesTextBox.Name = "filterGradesTextBox";
            filterGradesTextBox.Size = new Size(250, 27);
            filterGradesTextBox.TabIndex = 10;
            // 
            // filterGradesButton
            // 
            filterGradesButton.Location = new Point(455, 29);
            filterGradesButton.Name = "filterGradesButton";
            filterGradesButton.Size = new Size(123, 43);
            filterGradesButton.TabIndex = 11;
            filterGradesButton.Text = "Фільтрувати";
            filterGradesButton.Click += filterGradesButton_Click;
            // 
            // deleteGradeButton
            // 
            deleteGradeButton.Location = new Point(584, 78);
            deleteGradeButton.Name = "deleteGradeButton";
            deleteGradeButton.Size = new Size(123, 44);
            deleteGradeButton.TabIndex = 12;
            deleteGradeButton.Text = "Видалити";
            deleteGradeButton.Click += deleteGradeButton_Click;
            // 
            // updateGradeButton
            // 
            updateGradeButton.Location = new Point(711, 78);
            updateGradeButton.Name = "updateGradeButton";
            updateGradeButton.Size = new Size(123, 44);
            updateGradeButton.TabIndex = 13;
            updateGradeButton.Text = "Оновити";
            updateGradeButton.Click += updateGradeButton_Click;
            // 
            // addTaskTab
            // 
            addTaskTab.Controls.Add(taskTypeLabel);
            addTaskTab.Controls.Add(descriptionLabel);
            addTaskTab.Controls.Add(statusLabel);
            addTaskTab.Controls.Add(creationDateLabel);
            addTaskTab.Controls.Add(completionDateLabel);
            addTaskTab.Controls.Add(teacherIdTaskLabel);
            addTaskTab.Controls.Add(classLabelTask);
            addTaskTab.Controls.Add(groupLabelTask);
            addTaskTab.Controls.Add(taskTypeTextBox);
            addTaskTab.Controls.Add(descriptionTextBox);
            addTaskTab.Controls.Add(statusTextBox);
            addTaskTab.Controls.Add(teacherIdTaskTextBox);
            addTaskTab.Controls.Add(classTextBoxTask);
            addTaskTab.Controls.Add(groupTextBoxTask);
            addTaskTab.Controls.Add(creationDatePicker);
            addTaskTab.Controls.Add(completionDatePicker);
            addTaskTab.Controls.Add(addTaskButton);
            addTaskTab.Controls.Add(tasksGridView);
            addTaskTab.Controls.Add(filterTasksTextBox);
            addTaskTab.Controls.Add(filterTasksButton);
            addTaskTab.Controls.Add(deleteTaskButton);
            addTaskTab.Controls.Add(updateTaskButton);
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
            // teacherIdTaskLabel
            // 
            teacherIdTaskLabel.Location = new Point(28, 207);
            teacherIdTaskLabel.Name = "teacherIdTaskLabel";
            teacherIdTaskLabel.Size = new Size(100, 23);
            teacherIdTaskLabel.TabIndex = 6;
            teacherIdTaskLabel.Text = "ID вчителя:";
            // 
            // classLabelTask
            // 
            classLabelTask.Location = new Point(28, 240);
            classLabelTask.Name = "classLabelTask";
            classLabelTask.Size = new Size(100, 23);
            classLabelTask.TabIndex = 5;
            classLabelTask.Text = "Клас:";
            // 
            // groupLabelTask
            // 
            groupLabelTask.Location = new Point(28, 273);
            groupLabelTask.Name = "groupLabelTask";
            groupLabelTask.Size = new Size(100, 23);
            groupLabelTask.TabIndex = 6;
            groupLabelTask.Text = "Група:";
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
            // teacherIdTaskTextBox
            // 
            teacherIdTaskTextBox.Location = new Point(209, 203);
            teacherIdTaskTextBox.Name = "teacherIdTaskTextBox";
            teacherIdTaskTextBox.Size = new Size(200, 27);
            teacherIdTaskTextBox.TabIndex = 11;
            // 
            // classTextBoxTask
            // 
            classTextBoxTask.Location = new Point(209, 236);
            classTextBoxTask.Name = "classTextBoxTask";
            classTextBoxTask.Size = new Size(200, 27);
            classTextBoxTask.TabIndex = 10;
            // 
            // groupTextBoxTask
            // 
            groupTextBoxTask.Location = new Point(209, 269);
            groupTextBoxTask.Name = "groupTextBoxTask";
            groupTextBoxTask.Size = new Size(200, 27);
            groupTextBoxTask.TabIndex = 11;
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
            addTaskButton.Location = new Point(451, 112);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(117, 53);
            addTaskButton.TabIndex = 14;
            addTaskButton.Text = "Додати";
            addTaskButton.Click += addTaskButton_Click;
            // 
            // tasksGridView
            // 
            tasksGridView.ColumnHeadersHeight = 29;
            tasksGridView.Location = new Point(3, 302);
            tasksGridView.Name = "tasksGridView";
            tasksGridView.RowHeadersWidth = 51;
            tasksGridView.Size = new Size(840, 217);
            tasksGridView.TabIndex = 15;
            tasksGridView.CellDoubleClick += tasksGridView_CellDoubleClick;
            // 
            // filterTasksTextBox
            // 
            filterTasksTextBox.Location = new Point(574, 48);
            filterTasksTextBox.Name = "filterTasksTextBox";
            filterTasksTextBox.Size = new Size(240, 27);
            filterTasksTextBox.TabIndex = 16;
            // 
            // filterTasksButton
            // 
            filterTasksButton.Location = new Point(451, 38);
            filterTasksButton.Name = "filterTasksButton";
            filterTasksButton.Size = new Size(117, 47);
            filterTasksButton.TabIndex = 17;
            filterTasksButton.Text = "Фільтрувати";
            filterTasksButton.Click += filterTasksButton_Click;
            // 
            // deleteTaskButton
            // 
            deleteTaskButton.Location = new Point(574, 112);
            deleteTaskButton.Name = "deleteTaskButton";
            deleteTaskButton.Size = new Size(117, 53);
            deleteTaskButton.TabIndex = 18;
            deleteTaskButton.Text = "Видалити";
            deleteTaskButton.Click += deleteTaskButton_Click;
            // 
            // updateTaskButton
            // 
            updateTaskButton.Location = new Point(697, 112);
            updateTaskButton.Name = "updateTaskButton";
            updateTaskButton.Size = new Size(117, 53);
            updateTaskButton.TabIndex = 19;
            updateTaskButton.Text = "Оновити";
            updateTaskButton.Click += updateTaskButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(853, 556);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Електронний щоденник";
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
            ResumeLayout(false);
        }
    }
}
