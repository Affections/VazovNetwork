using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VazovNetwork.ViewModels
{
    public class AchivementViewModel
    {
          public int Id { get; set; }

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public int CompetitionId { get; set; }
        public string CompetitioName { get; set; }

        public int Year { get; set; }

        public string AchievmentExplanation { get; set; }

        public string AchievmentReward { get; set; }
    }
}
