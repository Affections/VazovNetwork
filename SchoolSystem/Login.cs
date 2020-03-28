using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VazovNetwork
{
    public partial class Login : Form
    {
        private global::VazovNetwork.Db.SchoolDbContext _db = new global::VazovNetwork.Db.SchoolDbContext();

        public Login()
        {
            InitializeComponent();

            if (_db.Database.CreateIfNotExists())
            {


                _db.Database.Initialize(false);

                if (_db.Users.Count() == 0)
                {
                    _db.Users.Add(new Db.Users()
                    {
                        Username = "admin",
                        Password = "admin"
                    }
                       );

                    //var student = new Db.Student()
                    //{
                    //    Name = "blago",
                    //    Class = "5 клас"

                    //};

                    //var achievement = new Db.Achievment()
                    //{
                    //    Year = 2002,
                    //    AchievmentExplanation = "Бургас 20.03.2020 Международен конкурс",
                    //    AchievmentReward = "Медал 1-во място",

                    //};


                    //student.Achievments.Add(achievement);

                    //achievement.Subject = new Db.Subject()
                    //{
                    //    Name = "English"

                    //};
                    //achievement.Competition = new Db.Competition()
                    //{
                    //    Type = "Общински"

                    //};

                    //_db.Students.Add(student);


                    _db.SaveChanges();
                }
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _db.Users.First(x => x.Username == username.Text && x.Password == password.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Грешно име или парола", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
