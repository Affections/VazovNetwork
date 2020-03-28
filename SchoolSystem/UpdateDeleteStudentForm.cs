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
            textBoxClass.Text = student.Class;
            try
            {
                byte[] imageSource = student.Picture;
                Bitmap image;
                using (MemoryStream stream = new MemoryStream(imageSource))
                {
                    image = new Bitmap(stream);
                }
                StudentImage.Image = image;
            }
            catch (Exception)
            {
                MessageBox.Show("Няма снимка", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            StudentId = studentId;
        }

        public int StudentId { get; set; }

        public Db.SchoolDbContext _db = new Db.SchoolDbContext();

        

     

     

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
            
            int id = Convert.ToInt32(textBoxID.Text);
            var student = _db.Students.Find(id);
            string name = NameBox.Text;
           
            string classS = textBoxClass.Text;
        
            MemoryStream picture = new MemoryStream();

        
          

            if (verify())
            {
               

                try
                {
                    try
                    {
                        StudentImage.Image.Save(picture, StudentImage.Image.RawFormat);
                    }
                    catch (Exception)
                    {

                        
                    }
                    try
                    {
                        if(!String.IsNullOrEmpty(name))
                        {
                            student.Name = name;
                        }
                       
                    }
                    catch (Exception)
                    {

                        
                    }
                    try
                    {
                        if(!String.IsNullOrEmpty(classS))
                        {
                            student.Class = classS;
                        }
                        
                    }
                    catch (Exception)
                    {

                        
                    }
                    try
                    {
                          student.Picture = picture.ToArray();
                        
                        
                    }
                    catch (Exception)
                    {

                       
                    }
                  
                    _db.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Информацията за ученика е обновена", "Успешна промяна", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Няма промени", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
              
           
            }
            else
            {
                MessageBox.Show("Има празни полета!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }



     

       

       
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
        
            if (MessageBox.Show("Сигурни ли сте, че искате да изтриете този ученик ?", "Изтриване на ученик", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              

                    _db.Entry(student).State = EntityState.Deleted;
                    _db.SaveChanges();
                this.DialogResult = DialogResult.OK;



            }
            else
            {
                MessageBox.Show("Ученикът не е изтрит", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxClass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
