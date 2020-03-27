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
    public partial class AddNewAchievment : Form
    {
        public AddNewAchievment(int studentId)
        {
            InitializeComponent();
            var student = _db.Students.Find(studentId);
            studentIdBox.Text = studentId.ToString();

            var subjects = _db.Subjects.ToList();

            SubjectList.DataSource = subjects;
            SubjectList.Refresh();

            var competition = _db.Competitions.ToList();

            CompetitionList.DataSource = competition;
            CompetitionList.Refresh();
        }

        public Db.SchoolDbContext _db = new Db.SchoolDbContext();

        private void AddAchievment_Click(object sender, EventArgs e)
        {

            try
            {
                var achievment = new Db.Achievment()
                {
                    StudentId = int.Parse(studentIdBox.Text),
                    SubjectId = ((Db.Subject)SubjectList.SelectedItem).Id,
                    CompetitionId = ((Db.Competition)CompetitionList.SelectedItem).Id,
                    Year = int.Parse(yearBox.Text),
                    AchievmentExplanation = explanBox.Text,
                    AchievmentReward = rewardBox.Text

                };
                _db.Achievments.Add(achievment);
            }
            catch (Exception)
            {
                MessageBox.Show("You missed a field", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //_db.Achievments.Add(achievment);
            try
            {
                _db.SaveChanges();
                MessageBox.Show("new achievment added", "add achievment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("error", "add achievment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddNewAchievment_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
