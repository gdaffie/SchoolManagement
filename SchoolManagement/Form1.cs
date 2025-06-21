using System.Data;
using System.Data.SqlClient;




namespace SchoolManagement
{
    public partial class management_page : Form
    {
        public management_page()
        {
            InitializeComponent();
        }



        // Load Combobox Categories
        private void management_page_Load(object sender, EventArgs e)
        {

            student_course_box.Items.Add("JD521");
            student_course_box.Items.Add("PRG521");
            student_course_box.Items.Add("SLD521");
            teacher_course.Items.Add("JD521");
            teacher_course.Items.Add("PRG521");
            teacher_course.Items.Add("SLD521");
            course_search.Items.Add("JD521");
            course_search.Items.Add("PRG521");
            course_search.Items.Add("SLD521");
        }



        //-------------------- STUDENT MANAGEMENT --------------------\\



        // SEARCH for student record
        private void search_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from StudentDetails where student_id = @student_id ", con);
                cmd.Parameters.AddWithValue("student_id", int.Parse(search_box.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                student_datagrid.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Please enter a student ID to search for!");
            }
        }

        // EXIT program from student management
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // DELETE student record
        private void delete_student_btn_Click(object sender, EventArgs e)
        {

            try
            {


                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                SqlCommand cmd = new SqlCommand("Delete StudentDetails where student_id=@student_id", con);
                cmd.Parameters.AddWithValue("@student_id", int.Parse(student_id_box.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Record Successfully Deleted!");
            }
            catch
            {
                MessageBox.Show("Please enter a Student ID first!");

            }



        }


        // UPDATE student record
        private void update_student_btn_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (gender_male_btn.Checked)
            {
                gender = "Male";
            }
            else if (gender_female_btn.Checked)
            {
                gender = "Female";
            }

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("update StudentDetails set student_name = @student_name, student_gender = @student_gender, student_number = @student_number, student_course = @student_course, student_address = @student_address where student_id = @student_id", con);

            cmd.Parameters.AddWithValue("@student_id", student_id_box.Text);
            cmd.Parameters.AddWithValue("@student_name", student_name_box.Text);
            cmd.Parameters.AddWithValue("@student_gender", gender);
            cmd.Parameters.AddWithValue("@student_number", student_num_box.Text);
            cmd.Parameters.AddWithValue("@student_course", student_course_box.Text);
            cmd.Parameters.AddWithValue("@student_address", student_address_box.Text);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Student Record Successfully Updated!");
        }


        // CLEAR student entry
        private void clear_student_btn_Click(object sender, EventArgs e)
        {
            student_id_box.Text = string.Empty;
            student_name_box.Text = string.Empty;
            student_num_box.Text = string.Empty;
            student_course_box.Text = string.Empty;
            student_address_box.Text = string.Empty;
        }


        // ADD student to database
        private void add_student_btn_Click_1(object sender, EventArgs e)
        {
            try
            {


                string gender = "";

                if (gender_male_btn.Checked)
                {
                    gender = "Male";
                }
                else if (gender_female_btn.Checked)
                {
                    gender = "Female";
                }

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentDetails values (@student_id,@student_name,@student_gender, @student_course,@student_number,@student_address) ", con);
                cmd.Parameters.AddWithValue("@student_id", int.Parse(student_id_box.Text));
                cmd.Parameters.AddWithValue("@student_name", student_name_box.Text);
                cmd.Parameters.AddWithValue("@student_gender", gender);
                cmd.Parameters.AddWithValue("@student_number", int.Parse(student_num_box.Text));
                cmd.Parameters.AddWithValue("@student_course", student_course_box.Text);
                cmd.Parameters.AddWithValue("@student_address", student_address_box.Text);
                cmd.ExecuteNonQuery();


                con.Close();

                MessageBox.Show("Student Record Successfully Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please submit a valid entry");
            }
        }




        //-------------------- TEACHER MANAGEMENT --------------------\\



        // ADD teacher to database
        private void teacher_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";

                if (teacher_gender_male.Checked)
                {
                    gender = "Male";
                }
                else if (teacher_gender_female.Checked)
                {
                    gender = "Female";
                }

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TeacherDetails values (@teacher_id,@teacher_name,@teacher_gender, @teacher_course,@teacher_number,@teacher_department) ", con);
                cmd.Parameters.AddWithValue("@teacher_id", int.Parse(teacher_id.Text));
                cmd.Parameters.AddWithValue("@teacher_name", teacher_name.Text);
                cmd.Parameters.AddWithValue("@teacher_gender", gender);
                cmd.Parameters.AddWithValue("@teacher_number", int.Parse(teacher_num.Text));
                cmd.Parameters.AddWithValue("@teacher_course", teacher_course.Text);
                cmd.Parameters.AddWithValue("@teacher_department", teacher_department.Text);
                cmd.ExecuteNonQuery();


                con.Close();

                MessageBox.Show("Teacher Record Successfully Added!");
            }
            catch
            {
                MessageBox.Show("Please submit a valid entry");
            }
        }

        // CLEAR teacher from database
        private void teacher_clear_btn_Click(object sender, EventArgs e)
        {
            teacher_id.Text = string.Empty;
            teacher_name.Text = string.Empty;
            teacher_num.Text = string.Empty;
            teacher_course.Text = string.Empty;
            teacher_department.Text = string.Empty;
        }


        // UPDATE teacher record
        private void teacher_update_btn_Click(object sender, EventArgs e)
        {
            try
            {


                string gender = "";

                if (teacher_gender_male.Checked)
                {
                    gender = "Male";
                }
                else if (teacher_gender_female.Checked)
                {
                    gender = "Female";
                }

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("update TeacherDetails set teacher_name = @teacher_name, teacher_gender = @teacher_gender, teacher_num = @teacher_num, teacher_course = @teacher_course, teacher_department = @teacher_department where teacher_id = @teacher_id", con);
                cmd.Parameters.AddWithValue("@teacher_id", int.Parse(teacher_id.Text));
                cmd.Parameters.AddWithValue("@teacher_name", teacher_name.Text);
                cmd.Parameters.AddWithValue("@teacher_gender", gender);
                cmd.Parameters.AddWithValue("@teacher_num", int.Parse(teacher_num.Text));
                cmd.Parameters.AddWithValue("@teacher_course", teacher_course.Text);
                cmd.Parameters.AddWithValue("@teacher_department", teacher_department.Text);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Teacher Record Successfully Updated!");
            }
            catch
            {
                MessageBox.Show("Please submit a valid entry");
            }
        }


        // DELETE teacher record
        private void teacher_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                SqlCommand cmd = new SqlCommand("Delete TeacherDetails where teacher_id=@teacher_id", con);
                cmd.Parameters.AddWithValue("@teacher_id", int.Parse(teacher_id.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Teacher Record Successfully Deleted!");
            }
            catch
            {
                MessageBox.Show("Please enter a Teacher ID first");
            }
        }

        // SEARCH for teacher
        private void teacher_search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from TeacherDetails where teacher_id = @teacher_id ", con);
                cmd.Parameters.AddWithValue("teacher_id", int.Parse(teacher_search.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                teacher_datagrid.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Please enter a teacher ID to search for!");
            }
        }

        // EXIT from teacher page
        private void teacher_exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //-------------------- COURSE MANAGEMENT --------------------\\

        // ADD course 
        private void course_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CourseDetails values (@course_id,@course_name,@course_category) ", con);
            cmd.Parameters.AddWithValue("@course_id", course_id.Text);
            cmd.Parameters.AddWithValue("@course_name", course_name.Text);
            cmd.Parameters.AddWithValue("@course_category", course_category.Text);


            cmd.ExecuteNonQuery();


            con.Close();

            MessageBox.Show("Course Added Successfully!");
        }

        // CLEAR course
        private void course_clear_Click(object sender, EventArgs e)
        {
            course_id.Text = string.Empty;
            course_name.Text = string.Empty;
            course_category.Text = string.Empty;

        }

        // UPDATE course
        private void course_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("update CourseDetails set course_name = @course_name, course_category = @course_category where course_id = @course_id", con);
            cmd.Parameters.AddWithValue("@course_id", course_id.Text);
            cmd.Parameters.AddWithValue("@course_name", course_name.Text);
            cmd.Parameters.AddWithValue("@course_category", course_category.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Course Updated Successfully!");
        }


        // DELETE Course 
        private void course_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete CourseDetails where course_id=@course_id", con);
            cmd.Parameters.AddWithValue("@course_id", course_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Course Record Successfully Deleted!");
        }

        // SEARCH Course
        private void course_search_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand students = new SqlCommand("Select * from StudentDetails where student_course = @student_course ", con);
            students.Parameters.AddWithValue("student_course", course_search.Text);
            SqlDataAdapter da = new SqlDataAdapter(students);
            DataTable dt = new DataTable();
            da.Fill(dt);
            course_datagrid.DataSource = dt;

        }


        // EXIT program from course management
        private void course_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }


}