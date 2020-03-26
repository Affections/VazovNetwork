namespace VazovNetwork
{
    partial class AllCompetition
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
            this.competitionsGrid = new System.Windows.Forms.DataGridView();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpravkaByCompetitions = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // competitionsGrid
            // 
            this.competitionsGrid.AllowUserToAddRows = false;
            this.competitionsGrid.AllowUserToDeleteRows = false;
            this.competitionsGrid.AutoGenerateColumns = false;
            this.competitionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competitionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.SpravkaByCompetitions});
            this.competitionsGrid.DataSource = this.competitionBindingSource;
            this.competitionsGrid.Location = new System.Drawing.Point(21, 52);
            this.competitionsGrid.Name = "competitionsGrid";
            this.competitionsGrid.ReadOnly = true;
            this.competitionsGrid.Size = new System.Drawing.Size(759, 347);
            this.competitionsGrid.TabIndex = 1;
            this.competitionsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.competitionsGrid_CellContentClick);
            // 
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataSource = typeof(Db.Competition);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SpravkaByCompetitions
            // 
            this.SpravkaByCompetitions.HeaderText = "Справка";
            this.SpravkaByCompetitions.Name = "SpravkaByCompetitions";
            this.SpravkaByCompetitions.ReadOnly = true;
            // 
            // AllCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.competitionsGrid);
            this.Name = "AllCompetition";
            this.Text = "AllCompetition";
            this.Load += new System.EventHandler(this.AllCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.competitionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView competitionsGrid;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SpravkaByCompetitions;
    }
}