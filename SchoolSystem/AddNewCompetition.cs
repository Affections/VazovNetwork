﻿using System;
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
         
            try
            {

                if (!String.IsNullOrEmpty(competitionBox.Text))
                {
                    var competition = new Db.Competition()
                    {
                        Type = competitionBox.Text,

                    };
                    _db.Competitions.Add(competition);
                }
                else
                {
                    MessageBox.Show("Невалидно състезание", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Невалидно състезание", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            try
            {
                _db.SaveChanges();
                MessageBox.Show("Ново състезание беше добавено", "Добавяне на състезание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Състезанието не можа да бъде добавено", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
