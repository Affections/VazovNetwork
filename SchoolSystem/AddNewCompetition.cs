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
    public partial class AddNewCompetition : Form
    {
        public AddNewCompetition()
        {
            InitializeComponent();
        }

        public Db.SchoolDbContext _db = new Db.SchoolDbContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            var competition = new Db.Competition()
            {
                Type = competitionBox.Text,

            };


            _db.Competitions.Add(competition);
            try
            {
                _db.SaveChanges();
                MessageBox.Show("new competition added", "competition add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("error", "competition add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subjectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
