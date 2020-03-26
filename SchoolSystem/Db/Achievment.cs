using System;

namespace VazovNetwork.Db
{
    public class Achievment
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }

        public int Year { get; set; }

        public string AchievmentExplanation { get; set; }

        public string AchievmentReward { get; set; }
    }
}