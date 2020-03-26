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
    public partial class AllAchievmentsSortedByCompetitions : Form
    {
        public AllAchievmentsSortedByCompetitions(int competitionId = 0)
        {
            InitializeComponent();
            refreshGrid(competitionId);
        }
        public Db.SchoolDbContext _db = new Db.SchoolDbContext();

        private void refreshGrid(int competitionId = 0)
        {

            var achievments = new List<ViewModels.AchivementViewModel>();
            achievmentsGrid.RowTemplate.Height = 80;



            achievments = _db.Achievments.Where(x => x.CompetitionId == competitionId).Select(z => new ViewModels.AchivementViewModel()
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

            achievmentsGrid.DataSource = achievments;
            achievmentsGrid.Refresh();
        }

    }
}
