namespace VazovNetwork
{
    partial class AllSubjects
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
            this.subjectsGrid = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpravkaBySubject = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsGrid
            // 
            this.subjectsGrid.AllowUserToAddRows = false;
            this.subjectsGrid.AllowUserToDeleteRows = false;
            this.subjectsGrid.AutoGenerateColumns = false;
            this.subjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.SpravkaBySubject});
            this.subjectsGrid.DataSource = this.subjectBindingSource;
            this.subjectsGrid.Location = new System.Drawing.Point(21, 52);
            this.subjectsGrid.Name = "subjectsGrid";
            this.subjectsGrid.ReadOnly = true;
            this.subjectsGrid.Size = new System.Drawing.Size(759, 347);
            this.subjectsGrid.TabIndex = 1;
            this.subjectsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectsGrid_CellContentClick);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Db.Subject);
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataSource = typeof(Db.Subject);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SpravkaBySubject
            // 
            this.SpravkaBySubject.HeaderText = "Справка";
            this.SpravkaBySubject.Name = "SpravkaBySubject";
            this.SpravkaBySubject.ReadOnly = true;
            // 
            // AllSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subjectsGrid);
            this.Name = "AllSubjects";
            this.Text = "AllSubjects";
            this.Load += new System.EventHandler(this.AllSubjects_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectsGrid;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SpravkaBySubject;
    }
}