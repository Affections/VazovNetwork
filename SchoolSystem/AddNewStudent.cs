﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VazovNetwork
{
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }
        public Db.SchoolDbContext _db = new Db.SchoolDbContext();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                StudentImage.Image = Image.FromFile(opf.FileName);

            }

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {      
            MemoryStream picture = new MemoryStream();        
           if (verify())
            {
                StudentImage.Image.Save(picture, StudentImage.Image.RawFormat);


                var student = new Db.Student()
                {
                    Name = NameBox.Text,

                    Class = classTextBox.Text,
                    Picture = picture.ToArray()

                };
               

                _db.Students.Add(student);

                try
                {
                    _db.SaveChanges();
                    MessageBox.Show("Беше добавен нов ученик/отбор", "Добавяне на нов ученик", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Не можа да се добави нов ученик/отбор", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("Има празни полета", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }




        }
        bool verify()
        {
            if((NameBox.Text.Trim() == "") ||                      
                (StudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //button close
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void classTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
