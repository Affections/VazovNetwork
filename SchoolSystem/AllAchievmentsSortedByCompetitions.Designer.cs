namespace VazovNetwork
{
    partial class AllAchievmentsSortedByCompetitions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.achievmentsGrid = new System.Windows.Forms.DataGridView();
            this.achievmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitioName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievmentExplanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievmentRewardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.achievmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // achievmentsGrid
            // 
            this.achievmentsGrid.AllowUserToAddRows = false;
            this.achievmentsGrid.AllowUserToDeleteRows = false;
            this.achievmentsGrid.AutoGenerateColumns = false;
            this.achievmentsGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.achievmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.achievmentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.CompetitioName,
            this.SubjectName,
            this.yearDataGridViewTextBoxColumn,
            this.achievmentExplanationDataGridViewTextBoxColumn,
            this.achievmentRewardDataGridViewTextBoxColumn});
            this.achievmentsGrid.DataSource = this.achievmentBindingSource;
            this.achievmentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.achievmentsGrid.Location = new System.Drawing.Point(0, 0);
            this.achievmentsGrid.Name = "achievmentsGrid";
            this.achievmentsGrid.ReadOnly = true;
            this.achievmentsGrid.RowHeadersVisible = false;
            this.achievmentsGrid.Size = new System.Drawing.Size(800, 450);
            this.achievmentsGrid.TabIndex = 2;
            // 
            // achievmentBindingSource
            // 
            this.achievmentBindingSource.DataSource = typeof(Db.Achievment);
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentName.DataPropertyName = "StudentName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentName.DefaultCellStyle = dataGridViewCellStyle1;
            this.StudentName.HeaderText = "Име";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 54;
            // 
            // CompetitioName
            // 
            this.CompetitioName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompetitioName.DataPropertyName = "CompetitioName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompetitioName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CompetitioName.HeaderText = "Състезание";
            this.CompetitioName.Name = "CompetitioName";
            this.CompetitioName.ReadOnly = true;
            this.CompetitioName.Width = 93;
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SubjectName.DataPropertyName = "SubjectName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectName.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubjectName.HeaderText = "Дисциплина";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.Width = 95;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Година";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // achievmentExplanationDataGridViewTextBoxColumn
            // 
            this.achievmentExplanationDataGridViewTextBoxColumn.DataPropertyName = "AchievmentExplanation";
            this.achievmentExplanationDataGridViewTextBoxColumn.HeaderText = "Информация";
            this.achievmentExplanationDataGridViewTextBoxColumn.Name = "achievmentExplanationDataGridViewTextBoxColumn";
            this.achievmentExplanationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // achievmentRewardDataGridViewTextBoxColumn
            // 
            this.achievmentRewardDataGridViewTextBoxColumn.DataPropertyName = "AchievmentReward";
            this.achievmentRewardDataGridViewTextBoxColumn.HeaderText = "Награда";
            this.achievmentRewardDataGridViewTextBoxColumn.Name = "achievmentRewardDataGridViewTextBoxColumn";
            this.achievmentRewardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AllAchievmentsSortedByCompetitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.achievmentsGrid);
            this.Name = "AllAchievmentsSortedByCompetitions";
            this.Text = "AllAchievmentsSortedByCompetitions";
            ((System.ComponentModel.ISupportInitialize)(this.achievmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView achievmentsGrid;
        private System.Windows.Forms.BindingSource achievmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetitioName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achievmentExplanationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achievmentRewardDataGridViewTextBoxColumn;
    }
}