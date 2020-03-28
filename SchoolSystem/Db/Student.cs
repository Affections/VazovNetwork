using System;
using System.Collections.Generic;

namespace VazovNetwork.Db
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }     
        public string Class { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Achievment> Achievments { get; set; } = new List<Achievment>();
    }
}


