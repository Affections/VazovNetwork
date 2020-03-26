namespace VazovNetwork
{
    partial class VazovNetwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VazovNetwork));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкНаВсичкиПостиженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавиПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкПредметиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.състезанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавиСъстезаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкСъстезанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Постижения = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stundetmodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.achievmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stundetmodelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTSToolStripMenuItem,
            this.competitionsToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.състезанияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(42, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sTUDENTSToolStripMenuItem
            // 
            this.sTUDENTSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sTUDENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem});
            this.sTUDENTSToolStripMenuItem.Name = "sTUDENTSToolStripMenuItem";
            this.sTUDENTSToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.sTUDENTSToolStripMenuItem.Text = "Ученици/Отбори";
            this.sTUDENTSToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTSToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.addNewStudentToolStripMenuItem.Text = "Добави ученик/отбор";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // competitionsToolStripMenuItem
            // 
            this.competitionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.competitionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списъкНаВсичкиПостиженияToolStripMenuItem});
            this.competitionsToolStripMenuItem.Name = "competitionsToolStripMenuItem";
            this.competitionsToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.competitionsToolStripMenuItem.Text = "Постижения";
            this.competitionsToolStripMenuItem.Click += new System.EventHandler(this.competitionsToolStripMenuItem_Click);
            // 
            // списъкНаВсичкиПостиженияToolStripMenuItem
            // 
            this.списъкНаВсичкиПостиженияToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.списъкНаВсичкиПостиженияToolStripMenuItem.Name = "списъкНаВсичкиПостиженияToolStripMenuItem";
            this.списъкНаВсичкиПостиженияToolStripMenuItem.Size = new System.Drawing.Size(350, 30);
            this.списъкНаВсичкиПостиженияToolStripMenuItem.Text = "Списък на всички постижения";
            this.списъкНаВсичкиПостиженияToolStripMenuItem.Click += new System.EventHandler(this.списъкНаВсичкиПостиженияToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиПредметToolStripMenuItem,
            this.списъкПредметиToolStripMenuItem});
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.scoreToolStripMenuItem.Text = "Предмети";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // добавиПредметToolStripMenuItem
            // 
            this.добавиПредметToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.добавиПредметToolStripMenuItem.Name = "добавиПредметToolStripMenuItem";
            this.добавиПредметToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.добавиПредметToolStripMenuItem.Text = "Добави предмет";
            this.добавиПредметToolStripMenuItem.Click += new System.EventHandler(this.добавиПредметToolStripMenuItem_Click);
            // 
            // списъкПредметиToolStripMenuItem
            // 
            this.списъкПредметиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.списъкПредметиToolStripMenuItem.Name = "списъкПредметиToolStripMenuItem";
            this.списъкПредметиToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.списъкПредметиToolStripMenuItem.Text = "Списък предмети";
            this.списъкПредметиToolStripMenuItem.Click += new System.EventHandler(this.списъкПредметиToolStripMenuItem_Click);
            // 
            // състезанияToolStripMenuItem
            // 
            this.състезанияToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.състезанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиСъстезаниеToolStripMenuItem,
            this.списъкСъстезанияToolStripMenuItem});
            this.състезанияToolStripMenuItem.Name = "състезанияToolStripMenuItem";
            this.състезанияToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.състезанияToolStripMenuItem.Text = "Състезания";
            this.състезанияToolStripMenuItem.Click += new System.EventHandler(this.състезанияToolStripMenuItem_Click);
            // 
            // добавиСъстезаниеToolStripMenuItem
            // 
            this.добавиСъстезаниеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.добавиСъстезаниеToolStripMenuItem.Name = "добавиСъстезаниеToolStripMenuItem";
            this.добавиСъстезаниеToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.добавиСъстезаниеToolStripMenuItem.Text = "Добави състезание";
            this.добавиСъстезаниеToolStripMenuItem.Click += new System.EventHandler(this.добавиСъстезаниеToolStripMenuItem_Click);
            // 
            // списъкСъстезанияToolStripMenuItem
            // 
            this.списъкСъстезанияToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.списъкСъстезанияToolStripMenuItem.Name = "списъкСъстезанияToolStripMenuItem";
            this.списъкСъстезанияToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.списъкСъстезанияToolStripMenuItem.Text = "Списък състезания";
            this.списъкСъстезанияToolStripMenuItem.Click += new System.EventHandler(this.списъкСъстезанияToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Date,
            this.pictureDataGridViewImageColumn,
            this.Постижения});
            this.dataGridView1.DataSource = this.stundetmodelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(629, 378);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 220;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 78;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Снимка";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Width = 150;
            // 
            // Постижения
            // 
            this.Постижения.HeaderText = "Постижения";
            this.Постижения.Name = "Постижения";
            this.Постижения.Width = 125;
            // 
            // stundetmodelBindingSource
            // 
            this.stundetmodelBindingSource.DataSource = typeof(ViewModels.Stundetmodel);
            // 
            // studentModelBindingSource
            // 
            this.studentModelBindingSource.CurrentChanged += new System.EventHandler(this.studentModelBindingSource_CurrentChanged);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // achievmentBindingSource
            // 
            this.achievmentBindingSource.DataSource = typeof(Db.Achievment);
            // 
            // VazovNetwork
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(653, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VazovNetwork";
            this.Text = "VazovNetwork";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stundetmodelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ToolStripMenuItem добавиПредметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списъкПредметиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem състезанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавиСъстезаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списъкСъстезанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списъкНаВсичкиПостиженияToolStripMenuItem;
        private System.Windows.Forms.BindingSource achievmentBindingSource;
        private System.Windows.Forms.BindingSource stundetmodelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Постижения;
    }
}