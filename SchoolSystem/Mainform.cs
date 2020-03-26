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
    public partial class VazovNetwork : Form
    {
        public VazovNetwork()
        {
            InitializeComponent();
            this.BringToFront();
            
        }
        public Db.SchoolDbContext _db = new Db.SchoolDbContext();

        private void refreshGrid()
        {
            var students = _db.Students.ToList();
            dataGridView1.DataSource = students;
            
        
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStudent addStdF = new AddNewStudent();

            if (addStdF.ShowDialog() == DialogResult.OK)
            {
                addStdF.Close();
                refreshGrid();
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    var cell = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

        //    int studentId = int.Parse(cell.ToString());
        //    UpdateDeleteStudentForm upDelStdF = new UpdateDeleteStudentForm(studentId);
        //    upDelStdF.Show();

        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageStudentsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sTUDENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
          
            DataGridViewColumn column = dataGridView1.Columns[3];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)dataGridView1.Columns[3]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dataGridView1.Rows[3].Height = 80;

            dataGridView1.RowTemplate.Height = 80;
            refreshGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            int studentId = int.Parse(cell.ToString());

            UpdateDeleteStudentForm updateDeleteStd = new UpdateDeleteStudentForm(studentId);
   


            if (updateDeleteStd.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Stretch(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                var cell = dataGridView1.Rows[e.RowIndex].Cells[0].Value; 
                int studentId = int.Parse(cell.ToString());
                AllAchievments allAchievmentsF = new AllAchievments(studentId);
                dataGridView1.RowTemplate.Height = 80;
        

                if (allAchievmentsF.ShowDialog() == DialogResult.OK)
                {
                    allAchievmentsF.Close();
                    refreshGrid();
                }

            }
        }

        private void competitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списъкНаВсичкиПостиженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllAchievments allAchievmentsF = new AllAchievments();

            if (allAchievmentsF.ShowDialog() == DialogResult.OK)
            {
                allAchievmentsF.Close();
                refreshGrid();
            }

        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавиПредметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSubject newSubjectF = new AddNewSubject();

            if (newSubjectF.ShowDialog() == DialogResult.OK)
            {
                newSubjectF.Close();
                refreshGrid();
            }
        }

        private void добавиСъстезаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCompetition newCompetitionF = new AddNewCompetition();

            if (newCompetitionF.ShowDialog() == DialogResult.OK)
            {
                newCompetitionF.Close();
                refreshGrid();
            }
        }

        private void всичкиУченициотбориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AllStudents allStudentsF = new AllStudents();

            //if (allStudentsF.ShowDialog() == DialogResult.OK)
            //{
            //    allStudentsF.Close();
            //    refreshGrid();
            //}
        }

        private void списъкПредметиToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                AllSubjects allSubjectsF = new AllSubjects();

                if (allSubjectsF.ShowDialog() == DialogResult.OK)
                {
                    allSubjectsF.Close();
                    refreshGrid();
                }
           
        }

        private void списъкСъстезанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCompetition allCompetitionsF = new AllCompetition();

            if (allCompetitionsF.ShowDialog() == DialogResult.OK)
            {
                allCompetitionsF.Close();
                refreshGrid();
            }
        }

        private void studentModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void състезанияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        /* private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             //display the selected student  in a new form to edit/remvoe
             UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
             updateDeleteStdF.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             updateDeleteStdF.NameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
             updateDeleteStdF.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
             updateDeleteStdF.PhoneBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
             updateDeleteStdF.AchievmentsBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

             //the image

             byte[] pic;
             pic = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
             MemoryStream picture = new MemoryStream(pic);
             updateDeleteStdF.StudentImage.Image = Image.FromStream(picture);
             updateDeleteStdF.Show(); 
         } */
    }
}
