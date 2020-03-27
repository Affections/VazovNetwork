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
    public partial class AllSubjects : Form
    {
        public AllSubjects()
        {

         
            InitializeComponent();
        }
        public Db.SchoolDbContext _db = new Db.SchoolDbContext();
        private void refreshGrid()
        {

            var subjects = _db.Subjects.ToList();
            subjectsGrid.RowTemplate.Height = 30;
            subjectsGrid.Dock = DockStyle.Fill;
            subjectsGrid.BorderStyle = BorderStyle.None;
            subjectsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            subjectsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            subjectsGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            subjectsGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            subjectsGrid.BackgroundColor = Color.White;

            subjectsGrid.EnableHeadersVisualStyles = false;
            subjectsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            subjectsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            subjectsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            subjectsGrid.DataSource = subjects;
            subjectsGrid.Refresh();

        }

        private void subjectsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                var cell = subjectsGrid.Rows[e.RowIndex].Cells[0].Value;
                int subjectId = int.Parse(cell.ToString());
                AllAchievmentsSortedBySubject allAchievmentsF = new AllAchievmentsSortedBySubject(subjectId);
                subjectsGrid.RowTemplate.Height = 80;


                if (allAchievmentsF.ShowDialog() == DialogResult.OK)
                {
                    allAchievmentsF.Close();
                    refreshGrid();
                }

            }
          
        }
   
        private void AllSubjects_Load_1(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
