namespace SchoolManagement
{
    partial class management_page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            student_course_box = new ComboBox();
            student_datagrid = new DataGridView();
            gender_female_btn = new RadioButton();
            gender_male_btn = new RadioButton();
            add_student_btn = new Button();
            clear_student_btn = new Button();
            update_student_btn = new Button();
            delete_student_btn = new Button();
            exit_btn = new Button();
            search_btn = new Button();
            student_address_box = new RichTextBox();
            search_box = new TextBox();
            student_num_box = new TextBox();
            student_name_box = new TextBox();
            student_id_box = new TextBox();
            address_lb = new Label();
            contact_num_lb = new Label();
            course_enrolled_lb = new Label();
            gender_lb = new Label();
            full_name_lb = new Label();
            student_id_lb = new Label();
            student_heading = new Label();
            tabPage2 = new TabPage();
            teacher_course = new ComboBox();
            teacher_num = new TextBox();
            teacher_datagrid = new DataGridView();
            teacher_gender_female = new RadioButton();
            teacher_gender_male = new RadioButton();
            teacher_add_btn = new Button();
            teacher_clear_btn = new Button();
            teacher_update_btn = new Button();
            teacher_delete_btn = new Button();
            teacher_exit_btn = new Button();
            teacher_search_btn = new Button();
            teacher_search = new TextBox();
            teacher_department = new TextBox();
            teacher_name = new TextBox();
            teacher_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            coure_management_tab = new TabPage();
            course_search = new ComboBox();
            course_category = new TextBox();
            course_name = new TextBox();
            course_id = new TextBox();
            course_search_btn = new Button();
            course_datagrid = new DataGridView();
            course_add = new Button();
            course_clear = new Button();
            course_update = new Button();
            course_delete = new Button();
            course_exit = new Button();
            label10 = new Label();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_datagrid).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_datagrid).BeginInit();
            coure_management_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)course_datagrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(coure_management_tab);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1258, 594);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(student_course_box);
            tabPage1.Controls.Add(student_datagrid);
            tabPage1.Controls.Add(gender_female_btn);
            tabPage1.Controls.Add(gender_male_btn);
            tabPage1.Controls.Add(add_student_btn);
            tabPage1.Controls.Add(clear_student_btn);
            tabPage1.Controls.Add(update_student_btn);
            tabPage1.Controls.Add(delete_student_btn);
            tabPage1.Controls.Add(exit_btn);
            tabPage1.Controls.Add(search_btn);
            tabPage1.Controls.Add(student_address_box);
            tabPage1.Controls.Add(search_box);
            tabPage1.Controls.Add(student_num_box);
            tabPage1.Controls.Add(student_name_box);
            tabPage1.Controls.Add(student_id_box);
            tabPage1.Controls.Add(address_lb);
            tabPage1.Controls.Add(contact_num_lb);
            tabPage1.Controls.Add(course_enrolled_lb);
            tabPage1.Controls.Add(gender_lb);
            tabPage1.Controls.Add(full_name_lb);
            tabPage1.Controls.Add(student_id_lb);
            tabPage1.Controls.Add(student_heading);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1250, 566);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student Management";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // student_course_box
            // 
            student_course_box.BackColor = SystemColors.ActiveBorder;
            student_course_box.FormattingEnabled = true;
            student_course_box.Location = new Point(236, 268);
            student_course_box.Name = "student_course_box";
            student_course_box.Size = new Size(186, 23);
            student_course_box.TabIndex = 45;
            // 
            // student_datagrid
            // 
            student_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_datagrid.Location = new Point(510, 157);
            student_datagrid.Name = "student_datagrid";
            student_datagrid.RowTemplate.Height = 25;
            student_datagrid.Size = new Size(678, 312);
            student_datagrid.TabIndex = 44;
            // 
            // gender_female_btn
            // 
            gender_female_btn.AutoSize = true;
            gender_female_btn.Location = new Point(347, 212);
            gender_female_btn.Name = "gender_female_btn";
            gender_female_btn.Size = new Size(63, 19);
            gender_female_btn.TabIndex = 43;
            gender_female_btn.TabStop = true;
            gender_female_btn.Text = "Female";
            gender_female_btn.UseVisualStyleBackColor = true;
            // 
            // gender_male_btn
            // 
            gender_male_btn.AutoSize = true;
            gender_male_btn.Location = new Point(254, 212);
            gender_male_btn.Name = "gender_male_btn";
            gender_male_btn.Size = new Size(51, 19);
            gender_male_btn.TabIndex = 42;
            gender_male_btn.TabStop = true;
            gender_male_btn.Text = "Male";
            gender_male_btn.UseVisualStyleBackColor = true;
            // 
            // add_student_btn
            // 
            add_student_btn.BackColor = Color.FromArgb(128, 128, 255);
            add_student_btn.ForeColor = SystemColors.Control;
            add_student_btn.Location = new Point(254, 499);
            add_student_btn.Name = "add_student_btn";
            add_student_btn.Size = new Size(75, 23);
            add_student_btn.TabIndex = 41;
            add_student_btn.Text = "ADD STUDENT";
            add_student_btn.UseVisualStyleBackColor = false;
            add_student_btn.Click += add_student_btn_Click_1;
            // 
            // clear_student_btn
            // 
            clear_student_btn.BackColor = Color.FromArgb(128, 128, 255);
            clear_student_btn.ForeColor = SystemColors.Control;
            clear_student_btn.Location = new Point(347, 499);
            clear_student_btn.Name = "clear_student_btn";
            clear_student_btn.Size = new Size(75, 23);
            clear_student_btn.TabIndex = 40;
            clear_student_btn.Text = "CLEAR";
            clear_student_btn.UseVisualStyleBackColor = false;
            clear_student_btn.Click += clear_student_btn_Click;
            // 
            // update_student_btn
            // 
            update_student_btn.BackColor = Color.FromArgb(128, 128, 255);
            update_student_btn.ForeColor = SystemColors.Control;
            update_student_btn.Location = new Point(926, 499);
            update_student_btn.Name = "update_student_btn";
            update_student_btn.Size = new Size(75, 23);
            update_student_btn.TabIndex = 39;
            update_student_btn.Text = "UPDATE";
            update_student_btn.UseVisualStyleBackColor = false;
            update_student_btn.Click += update_student_btn_Click;
            // 
            // delete_student_btn
            // 
            delete_student_btn.BackColor = Color.FromArgb(128, 128, 255);
            delete_student_btn.ForeColor = SystemColors.Control;
            delete_student_btn.Location = new Point(1018, 499);
            delete_student_btn.Name = "delete_student_btn";
            delete_student_btn.Size = new Size(75, 23);
            delete_student_btn.TabIndex = 38;
            delete_student_btn.Text = "DELETE";
            delete_student_btn.UseVisualStyleBackColor = false;
            delete_student_btn.Click += delete_student_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.FromArgb(128, 128, 255);
            exit_btn.ForeColor = SystemColors.Control;
            exit_btn.Location = new Point(1113, 499);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(75, 23);
            exit_btn.TabIndex = 37;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.FromArgb(128, 128, 255);
            search_btn.ForeColor = SystemColors.Control;
            search_btn.Location = new Point(1097, 112);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(75, 23);
            search_btn.TabIndex = 36;
            search_btn.Text = "SEARCH";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click_1;
            // 
            // student_address_box
            // 
            student_address_box.BackColor = SystemColors.ActiveBorder;
            student_address_box.Location = new Point(236, 373);
            student_address_box.Name = "student_address_box";
            student_address_box.Size = new Size(186, 96);
            student_address_box.TabIndex = 35;
            student_address_box.Text = "";
            // 
            // search_box
            // 
            search_box.BackColor = SystemColors.ActiveBorder;
            search_box.Location = new Point(861, 112);
            search_box.Name = "search_box";
            search_box.Size = new Size(186, 23);
            search_box.TabIndex = 34;
            // 
            // student_num_box
            // 
            student_num_box.BackColor = SystemColors.ActiveBorder;
            student_num_box.Location = new Point(236, 321);
            student_num_box.Name = "student_num_box";
            student_num_box.Size = new Size(186, 23);
            student_num_box.TabIndex = 33;
            // 
            // student_name_box
            // 
            student_name_box.BackColor = SystemColors.ActiveBorder;
            student_name_box.Location = new Point(236, 154);
            student_name_box.Name = "student_name_box";
            student_name_box.Size = new Size(186, 23);
            student_name_box.TabIndex = 31;
            // 
            // student_id_box
            // 
            student_id_box.BackColor = SystemColors.ActiveBorder;
            student_id_box.Location = new Point(236, 95);
            student_id_box.Name = "student_id_box";
            student_id_box.Size = new Size(186, 23);
            student_id_box.TabIndex = 30;
            // 
            // address_lb
            // 
            address_lb.AutoSize = true;
            address_lb.Location = new Point(63, 373);
            address_lb.Name = "address_lb";
            address_lb.Size = new Size(55, 15);
            address_lb.TabIndex = 29;
            address_lb.Text = "Address :";
            // 
            // contact_num_lb
            // 
            contact_num_lb.AutoSize = true;
            contact_num_lb.Location = new Point(63, 324);
            contact_num_lb.Name = "contact_num_lb";
            contact_num_lb.Size = new Size(102, 15);
            contact_num_lb.TabIndex = 28;
            contact_num_lb.Text = "Contact Number :";
            // 
            // course_enrolled_lb
            // 
            course_enrolled_lb.AutoSize = true;
            course_enrolled_lb.Location = new Point(63, 271);
            course_enrolled_lb.Name = "course_enrolled_lb";
            course_enrolled_lb.Size = new Size(96, 15);
            course_enrolled_lb.TabIndex = 27;
            course_enrolled_lb.Text = "Course Enrolled :";
            // 
            // gender_lb
            // 
            gender_lb.AutoSize = true;
            gender_lb.Location = new Point(63, 214);
            gender_lb.Name = "gender_lb";
            gender_lb.Size = new Size(51, 15);
            gender_lb.TabIndex = 26;
            gender_lb.Text = "Gender :";
            // 
            // full_name_lb
            // 
            full_name_lb.AutoSize = true;
            full_name_lb.Location = new Point(63, 157);
            full_name_lb.Name = "full_name_lb";
            full_name_lb.Size = new Size(67, 15);
            full_name_lb.TabIndex = 25;
            full_name_lb.Text = "Full Name :";
            // 
            // student_id_lb
            // 
            student_id_lb.AutoSize = true;
            student_id_lb.Location = new Point(63, 98);
            student_id_lb.Name = "student_id_lb";
            student_id_lb.Size = new Size(68, 15);
            student_id_lb.TabIndex = 24;
            student_id_lb.Text = "Student ID :";
            // 
            // student_heading
            // 
            student_heading.AutoSize = true;
            student_heading.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            student_heading.ForeColor = SystemColors.MenuHighlight;
            student_heading.Location = new Point(564, 46);
            student_heading.Name = "student_heading";
            student_heading.Size = new Size(201, 28);
            student_heading.TabIndex = 23;
            student_heading.Text = "Student Management";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(teacher_course);
            tabPage2.Controls.Add(teacher_num);
            tabPage2.Controls.Add(teacher_datagrid);
            tabPage2.Controls.Add(teacher_gender_female);
            tabPage2.Controls.Add(teacher_gender_male);
            tabPage2.Controls.Add(teacher_add_btn);
            tabPage2.Controls.Add(teacher_clear_btn);
            tabPage2.Controls.Add(teacher_update_btn);
            tabPage2.Controls.Add(teacher_delete_btn);
            tabPage2.Controls.Add(teacher_exit_btn);
            tabPage2.Controls.Add(teacher_search_btn);
            tabPage2.Controls.Add(teacher_search);
            tabPage2.Controls.Add(teacher_department);
            tabPage2.Controls.Add(teacher_name);
            tabPage2.Controls.Add(teacher_id);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1250, 566);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teacher Management";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // teacher_course
            // 
            teacher_course.BackColor = SystemColors.ActiveBorder;
            teacher_course.FormattingEnabled = true;
            teacher_course.Location = new Point(236, 268);
            teacher_course.Name = "teacher_course";
            teacher_course.Size = new Size(186, 23);
            teacher_course.TabIndex = 68;
            // 
            // teacher_num
            // 
            teacher_num.BackColor = SystemColors.ActiveBorder;
            teacher_num.Location = new Point(236, 370);
            teacher_num.Name = "teacher_num";
            teacher_num.Size = new Size(186, 23);
            teacher_num.TabIndex = 67;
            // 
            // teacher_datagrid
            // 
            teacher_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacher_datagrid.Location = new Point(510, 157);
            teacher_datagrid.Name = "teacher_datagrid";
            teacher_datagrid.RowTemplate.Height = 25;
            teacher_datagrid.Size = new Size(678, 312);
            teacher_datagrid.TabIndex = 66;
            // 
            // teacher_gender_female
            // 
            teacher_gender_female.AutoSize = true;
            teacher_gender_female.Location = new Point(347, 212);
            teacher_gender_female.Name = "teacher_gender_female";
            teacher_gender_female.Size = new Size(63, 19);
            teacher_gender_female.TabIndex = 65;
            teacher_gender_female.TabStop = true;
            teacher_gender_female.Text = "Female";
            teacher_gender_female.UseVisualStyleBackColor = true;
            // 
            // teacher_gender_male
            // 
            teacher_gender_male.AutoSize = true;
            teacher_gender_male.Location = new Point(254, 212);
            teacher_gender_male.Name = "teacher_gender_male";
            teacher_gender_male.Size = new Size(51, 19);
            teacher_gender_male.TabIndex = 64;
            teacher_gender_male.TabStop = true;
            teacher_gender_male.Text = "Male";
            teacher_gender_male.UseVisualStyleBackColor = true;
            // 
            // teacher_add_btn
            // 
            teacher_add_btn.BackColor = Color.FromArgb(128, 128, 255);
            teacher_add_btn.ForeColor = SystemColors.Control;
            teacher_add_btn.Location = new Point(254, 499);
            teacher_add_btn.Name = "teacher_add_btn";
            teacher_add_btn.Size = new Size(75, 23);
            teacher_add_btn.TabIndex = 63;
            teacher_add_btn.Text = "ADD STUDENT";
            teacher_add_btn.UseVisualStyleBackColor = false;
            teacher_add_btn.Click += teacher_add_btn_Click;
            // 
            // teacher_clear_btn
            // 
            teacher_clear_btn.BackColor = Color.FromArgb(128, 128, 255);
            teacher_clear_btn.ForeColor = SystemColors.Control;
            teacher_clear_btn.Location = new Point(347, 499);
            teacher_clear_btn.Name = "teacher_clear_btn";
            teacher_clear_btn.Size = new Size(75, 23);
            teacher_clear_btn.TabIndex = 62;
            teacher_clear_btn.Text = "CLEAR";
            teacher_clear_btn.UseVisualStyleBackColor = false;
            teacher_clear_btn.Click += teacher_clear_btn_Click;
            // 
            // teacher_update_btn
            // 
            teacher_update_btn.BackColor = Color.FromArgb(128, 128, 255);
            teacher_update_btn.ForeColor = SystemColors.Control;
            teacher_update_btn.Location = new Point(926, 499);
            teacher_update_btn.Name = "teacher_update_btn";
            teacher_update_btn.Size = new Size(75, 23);
            teacher_update_btn.TabIndex = 61;
            teacher_update_btn.Text = "UPDATE";
            teacher_update_btn.UseVisualStyleBackColor = false;
            teacher_update_btn.Click += teacher_update_btn_Click;
            // 
            // teacher_delete_btn
            // 
            teacher_delete_btn.BackColor = Color.FromArgb(128, 128, 255);
            teacher_delete_btn.ForeColor = SystemColors.Control;
            teacher_delete_btn.Location = new Point(1018, 499);
            teacher_delete_btn.Name = "teacher_delete_btn";
            teacher_delete_btn.Size = new Size(75, 23);
            teacher_delete_btn.TabIndex = 60;
            teacher_delete_btn.Text = "DELETE";
            teacher_delete_btn.UseVisualStyleBackColor = false;
            teacher_delete_btn.Click += teacher_delete_btn_Click;
            // 
            // teacher_exit_btn
            // 
            teacher_exit_btn.BackColor = Color.FromArgb(128, 128, 255);
            teacher_exit_btn.ForeColor = SystemColors.Control;
            teacher_exit_btn.Location = new Point(1113, 499);
            teacher_exit_btn.Name = "teacher_exit_btn";
            teacher_exit_btn.Size = new Size(75, 23);
            teacher_exit_btn.TabIndex = 59;
            teacher_exit_btn.Text = "EXIT";
            teacher_exit_btn.UseVisualStyleBackColor = false;
            teacher_exit_btn.Click += teacher_exit_btn_Click;
            // 
            // teacher_search_btn
            // 
            teacher_search_btn.BackColor = Color.FromArgb(128, 128, 255);
            teacher_search_btn.ForeColor = SystemColors.Control;
            teacher_search_btn.Location = new Point(1097, 112);
            teacher_search_btn.Name = "teacher_search_btn";
            teacher_search_btn.Size = new Size(75, 23);
            teacher_search_btn.TabIndex = 58;
            teacher_search_btn.Text = "SEARCH";
            teacher_search_btn.UseVisualStyleBackColor = false;
            teacher_search_btn.Click += teacher_search_btn_Click;
            // 
            // teacher_search
            // 
            teacher_search.BackColor = SystemColors.ActiveBorder;
            teacher_search.Location = new Point(861, 112);
            teacher_search.Name = "teacher_search";
            teacher_search.Size = new Size(186, 23);
            teacher_search.TabIndex = 56;
            // 
            // teacher_department
            // 
            teacher_department.BackColor = SystemColors.ActiveBorder;
            teacher_department.Location = new Point(236, 321);
            teacher_department.Name = "teacher_department";
            teacher_department.Size = new Size(186, 23);
            teacher_department.TabIndex = 55;
            // 
            // teacher_name
            // 
            teacher_name.BackColor = SystemColors.ActiveBorder;
            teacher_name.Location = new Point(236, 154);
            teacher_name.Name = "teacher_name";
            teacher_name.Size = new Size(186, 23);
            teacher_name.TabIndex = 53;
            // 
            // teacher_id
            // 
            teacher_id.BackColor = SystemColors.ActiveBorder;
            teacher_id.Location = new Point(236, 95);
            teacher_id.Name = "teacher_id";
            teacher_id.Size = new Size(186, 23);
            teacher_id.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 373);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 51;
            label1.Text = "Contact Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 324);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 50;
            label2.Text = "Department :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 271);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 49;
            label3.Text = "Course :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 214);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 48;
            label4.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 157);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 47;
            label5.Text = "Full Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 98);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 46;
            label6.Text = "Teacher ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(573, 42);
            label7.Name = "label7";
            label7.Size = new Size(198, 28);
            label7.TabIndex = 45;
            label7.Text = "Teacher Management";
            // 
            // coure_management_tab
            // 
            coure_management_tab.Controls.Add(course_search);
            coure_management_tab.Controls.Add(course_category);
            coure_management_tab.Controls.Add(course_name);
            coure_management_tab.Controls.Add(course_id);
            coure_management_tab.Controls.Add(course_search_btn);
            coure_management_tab.Controls.Add(course_datagrid);
            coure_management_tab.Controls.Add(course_add);
            coure_management_tab.Controls.Add(course_clear);
            coure_management_tab.Controls.Add(course_update);
            coure_management_tab.Controls.Add(course_delete);
            coure_management_tab.Controls.Add(course_exit);
            coure_management_tab.Controls.Add(label10);
            coure_management_tab.Controls.Add(label12);
            coure_management_tab.Controls.Add(label9);
            coure_management_tab.Controls.Add(label8);
            coure_management_tab.Location = new Point(4, 24);
            coure_management_tab.Name = "coure_management_tab";
            coure_management_tab.Padding = new Padding(3);
            coure_management_tab.Size = new Size(1250, 566);
            coure_management_tab.TabIndex = 2;
            coure_management_tab.Text = "Course Management";
            coure_management_tab.UseVisualStyleBackColor = true;
            // 
            // course_search
            // 
            course_search.BackColor = SystemColors.ActiveBorder;
            course_search.FormattingEnabled = true;
            course_search.Location = new Point(891, 104);
            course_search.Name = "course_search";
            course_search.Size = new Size(186, 23);
            course_search.TabIndex = 78;
            // 
            // course_category
            // 
            course_category.BackColor = SystemColors.ActiveBorder;
            course_category.Location = new Point(218, 319);
            course_category.Name = "course_category";
            course_category.Size = new Size(186, 23);
            course_category.TabIndex = 77;
            // 
            // course_name
            // 
            course_name.BackColor = SystemColors.ActiveBorder;
            course_name.Location = new Point(218, 250);
            course_name.Name = "course_name";
            course_name.Size = new Size(186, 23);
            course_name.TabIndex = 76;
            // 
            // course_id
            // 
            course_id.BackColor = SystemColors.ActiveBorder;
            course_id.Location = new Point(218, 191);
            course_id.Name = "course_id";
            course_id.Size = new Size(186, 23);
            course_id.TabIndex = 75;
            // 
            // course_search_btn
            // 
            course_search_btn.BackColor = Color.RoyalBlue;
            course_search_btn.ForeColor = SystemColors.Control;
            course_search_btn.Location = new Point(1096, 103);
            course_search_btn.Name = "course_search_btn";
            course_search_btn.Size = new Size(75, 23);
            course_search_btn.TabIndex = 74;
            course_search_btn.Text = "SEARCH";
            course_search_btn.UseVisualStyleBackColor = false;
            course_search_btn.Click += course_search_btn_Click;
            // 
            // course_datagrid
            // 
            course_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            course_datagrid.Location = new Point(493, 154);
            course_datagrid.Name = "course_datagrid";
            course_datagrid.RowTemplate.Height = 25;
            course_datagrid.Size = new Size(678, 312);
            course_datagrid.TabIndex = 72;
            // 
            // course_add
            // 
            course_add.BackColor = Color.RoyalBlue;
            course_add.ForeColor = SystemColors.Control;
            course_add.Location = new Point(218, 443);
            course_add.Name = "course_add";
            course_add.Size = new Size(75, 23);
            course_add.TabIndex = 71;
            course_add.Text = "ADD STUDENT";
            course_add.UseVisualStyleBackColor = false;
            course_add.Click += course_add_Click;
            // 
            // course_clear
            // 
            course_clear.BackColor = Color.RoyalBlue;
            course_clear.ForeColor = SystemColors.Control;
            course_clear.Location = new Point(329, 443);
            course_clear.Name = "course_clear";
            course_clear.Size = new Size(75, 23);
            course_clear.TabIndex = 70;
            course_clear.Text = "CLEAR";
            course_clear.UseVisualStyleBackColor = false;
            course_clear.Click += course_clear_Click;
            // 
            // course_update
            // 
            course_update.BackColor = Color.RoyalBlue;
            course_update.ForeColor = SystemColors.Control;
            course_update.Location = new Point(909, 485);
            course_update.Name = "course_update";
            course_update.Size = new Size(75, 23);
            course_update.TabIndex = 69;
            course_update.Text = "UPDATE";
            course_update.UseVisualStyleBackColor = false;
            course_update.Click += course_update_Click;
            // 
            // course_delete
            // 
            course_delete.BackColor = Color.RoyalBlue;
            course_delete.ForeColor = SystemColors.Control;
            course_delete.Location = new Point(1002, 485);
            course_delete.Name = "course_delete";
            course_delete.Size = new Size(75, 23);
            course_delete.TabIndex = 68;
            course_delete.Text = "DELETE";
            course_delete.UseVisualStyleBackColor = false;
            course_delete.Click += course_delete_Click;
            // 
            // course_exit
            // 
            course_exit.BackColor = Color.RoyalBlue;
            course_exit.ForeColor = SystemColors.Control;
            course_exit.Location = new Point(1096, 485);
            course_exit.Name = "course_exit";
            course_exit.Size = new Size(75, 23);
            course_exit.TabIndex = 67;
            course_exit.Text = "EXIT";
            course_exit.UseVisualStyleBackColor = false;
            course_exit.Click += course_exit_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Desktop;
            label10.Location = new Point(91, 250);
            label10.Name = "label10";
            label10.Size = new Size(112, 21);
            label10.TabIndex = 5;
            label10.Text = "Course Name :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Desktop;
            label12.Location = new Point(91, 319);
            label12.Name = "label12";
            label12.Size = new Size(80, 21);
            label12.TabIndex = 4;
            label12.Text = "Category :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Desktop;
            label9.Location = new Point(91, 191);
            label9.Name = "label9";
            label9.Size = new Size(85, 21);
            label9.TabIndex = 1;
            label9.Text = "Course ID :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(554, 53);
            label8.Name = "label8";
            label8.Size = new Size(193, 28);
            label8.TabIndex = 0;
            label8.Text = "Course Management";
            // 
            // management_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(tabControl1);
            Name = "management_page";
            Text = "Student Management";
            Load += management_page_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)student_datagrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_datagrid).EndInit();
            coure_management_tab.ResumeLayout(false);
            coure_management_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)course_datagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView student_datagrid;
        private RadioButton gender_female_btn;
        private RadioButton gender_male_btn;
        private Button add_student_btn;
        private Button clear_student_btn;
        private Button update_student_btn;
        private Button delete_student_btn;
        private Button exit_btn;
        private Button search_btn;
        private RichTextBox student_address_box;
        private TextBox search_box;
        private TextBox student_num_box;
        private TextBox student_name_box;
        private TextBox student_id_box;
        private Label address_lb;
        private Label contact_num_lb;
        private Label course_enrolled_lb;
        private Label gender_lb;
        private Label full_name_lb;
        private Label student_id_lb;
        private Label student_heading;
        private TabPage tabPage2;
        private DataGridView teacher_datagrid;
        private RadioButton teacher_gender_female;
        private RadioButton teacher_gender_male;
        private Button teacher_add_btn;
        private Button teacher_clear_btn;
        private Button teacher_update_btn;
        private Button teacher_delete_btn;
        private Button teacher_exit_btn;
        private Button teacher_search_btn;
        private TextBox teacher_search;
        private TextBox teacher_department;
        private TextBox teacher_name;
        private TextBox teacher_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox teacher_num;
        private TabPage coure_management_tab;
        private Label label8;
        private TextBox course_category;
        private TextBox course_name;
        private TextBox course_id;
        private Button course_search_btn;
        private DataGridView course_datagrid;
        private Button course_add;
        private Button course_clear;
        private Button course_update;
        private Button course_delete;
        private Button course_exit;
        private Label label10;
        private Label label12;
        private Label label9;
        private ComboBox student_course_box;
        private ComboBox teacher_course;
        private ComboBox course_search;
    }
}