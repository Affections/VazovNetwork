using System.Linq;
using System.Windows.Forms;

namespace VazovNetwork
{
    public partial class AllCompetition : Form
    {
        public AllCompetition()
        {
            InitializeComponent();
        }
        public Db.SchoolDbContext _db = new Db.SchoolDbContext();
        private void refreshGrid()
        {

            var competitions = _db.Competitions.ToList();
            competitionsGrid.DataSource = competitions;
            competitionsGrid.Refresh();

        }

        private void AllCompetition_Load(object sender, System.EventArgs e)
        {
            refreshGrid();
        }

        private void competitionsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                var cell = competitionsGrid.Rows[e.RowIndex].Cells[0].Value;
                int competitionId = int.Parse(cell.ToString());
                AllAchievmentsSortedByCompetitions allAchievmentsF = new AllAchievmentsSortedByCompetitions(competitionId);
                competitionsGrid.RowTemplate.Height = 80;


                if (allAchievmentsF.ShowDialog() == DialogResult.OK)
                {
                    allAchievmentsF.Close();
                    refreshGrid();
                }

            }
        }
    }
}
