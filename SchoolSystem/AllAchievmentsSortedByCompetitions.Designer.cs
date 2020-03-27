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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAchievmentsSortedByCompetitions));
            this.achievmentsGrid = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitioName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievmentExplanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievmentRewardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.achievmentsGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.achievmentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.achievmentsGrid.Location = new System.Drawing.Point(0, 0);
            this.achievmentsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.achievmentsGrid.Name = "achievmentsGrid";
            this.achievmentsGrid.ReadOnly = true;
            this.achievmentsGrid.RowHeadersVisible = false;
            this.achievmentsGrid.RowTemplate.Height = 25;
            this.achievmentsGrid.Size = new System.Drawing.Size(1200, 658);
            this.achievmentsGrid.TabIndex = 2;
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
            this.StudentName.Width = 64;
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
            this.CompetitioName.Width = 117;
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
            this.SubjectName.Width = 122;
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
            // achievmentBindingSource
            // 
            this.achievmentBindingSource.DataSource = typeof(Db.Achievment);
            // 
            // AllAchievmentsSortedByCompetitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.achievmentsGrid);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllAchievmentsSortedByCompetitions";
            this.Text = "Справка по състезания";
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