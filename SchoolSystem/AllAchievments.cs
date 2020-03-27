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
    public partial class AllAchievments : Form
    {
        public AllAchievments(int studentId = 0)
        {
            InitializeComponent();
            refreshGrid(studentId);
        }
        public Db.SchoolDbContext _db = new Db.SchoolDbContext();

        private void refreshGrid(int studentId = 0)
        {

            var achievments = new List<ViewModels.AchivementViewModel>();
            achievmentsGrid.RowTemplate.Height = 80;
            

            if (studentId > 0)
            {
                achievments = _db.Achievments.Where(x=> x.StudentId == studentId).Select(z=> new ViewModels.AchivementViewModel() {
                    Id = z.Id,
                    StudentId = z.Student.Id,
                    StudentName = z.Student.Name,
                    SubjectId = z.Subject.Id,
                    SubjectName = z.Subject.Name,
                    CompetitionId = z.Competition.Id,
                    CompetitioName = z.Competition.Type,
                    Year = z.Year,
                    AchievmentExplanation = z.AchievmentExplanation,
                    AchievmentReward = z.AchievmentReward
                     
                }).ToList();
            }
            else
            {
                achievments = _db.Achievments.Select(z => new ViewModels.AchivementViewModel()
                {
                    Id = z.Id,
                    StudentId = z.Student.Id,
                    StudentName = z.Student.Name,
                    SubjectId = z.Subject.Id,
                    SubjectName = z.Subject.Name,
                    CompetitionId = z.Competition.Id,
                    CompetitioName = z.Competition.Type,
                    Year = z.Year,
                    AchievmentExplanation = z.AchievmentExplanation,
                    AchievmentReward = z.AchievmentReward

                }).ToList();
            }
            
            achievmentsGrid.DataSource = achievments;
            achievmentsGrid.Refresh(); 
        }

        private void achievmentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllAchievments_Load(object sender, EventArgs e)
        {
            achievmentsGrid.Dock = DockStyle.Fill;
            achievmentsGrid.BorderStyle = BorderStyle.None;
            achievmentsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            achievmentsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            achievmentsGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            achievmentsGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            achievmentsGrid.BackgroundColor = Color.White;

            achievmentsGrid.EnableHeadersVisualStyles = false;
            achievmentsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            achievmentsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            achievmentsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        //private void achievmentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //   private void AllAchievments_Load(object sender, EventArgs e)
        //{

        //       var achievments = new Db.Achievment()
        //       {
        //            StudentId = st

        //       }

        //       refreshGrid();
        //   }

    }
}
