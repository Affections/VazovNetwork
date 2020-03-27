using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VazovNetwork
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm(int studentId)
        {
            InitializeComponent();
           
            var student = _db.Students.Find(studentId);
            textBoxID.Text = studentId.ToString();
            NameBox.Text = student.Name;

            byte[] imageSource = student.Picture;
            Bitmap image;
            using (MemoryStream stream = new MemoryStream(imageSource))
            {
                image = new Bitmap(stream);
            }
            StudentImage.Image = image;

            StudentId = studentId;
        }

        public int StudentId { get; set; }

        public Db.SchoolDbContext _db = new Db.SchoolDbContext();

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            // browse image from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                StudentImage.Image = Image.FromFile(opf.FileName);

            }
        }

        //create a function to verify data 
        bool verify()
        {
            if ((NameBox.Text.Trim() == "") ||                
                (StudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // updpate the selected student 
            //add new student
            //STUDENT student = new STUDENT();
            int id = Convert.ToInt32(textBoxID.Text);
            var student = _db.Students.Find(id);
            string name = NameBox.Text;
            DateTime date = dateTimePicker1.Value;
        
            MemoryStream picture = new MemoryStream();

            // we need to check the age of the student 
            // the  student age must be between 10-100
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
          

            if (verify())
            {
                StudentImage.Image.Save(picture, StudentImage.Image.RawFormat);

                student.Name = name;
                student.Date = date; 
                student.Picture = picture.ToArray();

                try
                {
                    _db.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("student info updated", "edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Error", "edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Empy Fields", "edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }



        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //STUDENT student = new STUDENT();
            //// remove the selected student
            //int id = Convert.ToInt32(textBoxID.Text);

            //// show a confirmation message before deleting the student 
            //if (MessageBox.Show("are you sure you want to delete current student?", "delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    if (student.deleteStudent(id))
            //    {
            //        MessageBox.Show("student deleted", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        // clear fields 
            //        textBoxID.Text = "";
            //        NameBox.Text = "";
            //        PhoneBox.Text = "";
            //        AchievmentsBox.Text = "";
            //        dateTimePicker1.Value = DateTime.Now;
            //        StudentImage.Image = null;

            //    }
            //    else
            //    {
            //        MessageBox.Show("student not deleted", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}



            //if (MessageBox.Show("are you sure you want to delete current student?", "delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{

            //    MessageBox.Show("student deleted", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    // clear fields                  
            //    student.Id = int.Parse("");
            //    student.Name = "";
            //    //student.Achievments = "";
            //    //student.Picture = "";
            //    //student.Date = "";




            //}
            //else
            //{
            //    MessageBox.Show("student not deleted", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
          

        }

        //private void buttonFind_Click(object sender, EventArgs e)
        //{
        //    STUDENT student = new STUDENT();

        //    // search student by id
        //    int id = Convert.ToInt32(textBoxID.Text);
        //    MySqlCommand command = new MySqlCommand($"SELECT `id`, `Name`, `Date`, `Phone`, `Achievments`, `Picture` FROM `student` WHERE `id`={id}");

        //    DataTable table = student.getStudents(command);


        //    if (table.Rows.Count > 0)
        //    {

        //        NameBox.Text = table.Rows[0]["Name"].ToString();
        //        PhoneBox.Text = table.Rows[0]["Phone"].ToString();
        //        AchievmentsBox.Text = table.Rows[0]["Achievments"].ToString();
        //        dateTimePicker1.Value = (DateTime)table.Rows[0]["Date"];



        //        byte[] pic = (byte[])table.Rows[0]["Picture"];
        //        MemoryStream picture = new MemoryStream(pic);
        //        StudentImage.Image = Image.FromStream(picture);

        //    }
        //}

        //allow only numbers on key press
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AddAchievment_Click(object sender, EventArgs e)
        {
            
            AddNewAchievment achievStdF = new AddNewAchievment(StudentId);

            if (achievStdF.ShowDialog() == DialogResult.OK)
            {
                achievStdF.Close();
              
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            var student = _db.Students.Find(id);
        
            if (MessageBox.Show("are you sure you want to delete current student?", "delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              

                    _db.Entry(student).State = EntityState.Deleted;
                    _db.SaveChanges();
                this.DialogResult = DialogResult.OK;



            }
            else
            {
                MessageBox.Show("student not deleted", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
