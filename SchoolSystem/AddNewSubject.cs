using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VazovNetwork
{
    public partial class AddNewSubject : Form
    {
        public AddNewSubject()
        {
            InitializeComponent();
        }
        public Db.SchoolDbContext _db = new Db.SchoolDbContext();

   

        private void subjectIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewSubject_Load(object sender, EventArgs e)
        {

        }

        private void AddSubject_Click(object sender, EventArgs e)
        {

            try
            {
              
                if (!String.IsNullOrEmpty(subjectBox.Text))
                {
                    var subject = new Db.Subject()
                    {
                        Name = subjectBox.Text,

                    };
                    _db.Subjects.Add(subject);
                }
               else
                {
                    MessageBox.Show("Невалидна дисциплина", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Невалидна дисциплина", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 


            
            try
            {
                _db.SaveChanges();
                MessageBox.Show("Беше добавена нова дисциплина", "Добавяне на дисциплина", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Не можа да бъде добавена нова дисциплина", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
