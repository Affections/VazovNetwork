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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.stundetmodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.achievmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Постижения = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stundetmodelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTSToolStripMenuItem,
            this.competitionsToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.състезанияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(86, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sTUDENTSToolStripMenuItem
            // 
            this.sTUDENTSToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.sTUDENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem});
            this.sTUDENTSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sTUDENTSToolStripMenuItem.Name = "sTUDENTSToolStripMenuItem";
            this.sTUDENTSToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sTUDENTSToolStripMenuItem.Text = "Ученици/Отбори";
            this.sTUDENTSToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTSToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.addNewStudentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.addNewStudentToolStripMenuItem.Text = "Добави ученик/отбор";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // competitionsToolStripMenuItem
            // 
            this.competitionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.competitionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списъкНаВсичкиПостиженияToolStripMenuItem});
            this.competitionsToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.competitionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.competitionsToolStripMenuItem.Name = "competitionsToolStripMenuItem";
            this.competitionsToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.competitionsToolStripMenuItem.Text = "Постижения";
            this.competitionsToolStripMenuItem.Click += new System.EventHandler(this.competitionsToolStripMenuItem_Click);
            // 
            // списъкНаВсичкиПостиженияToolStripMenuItem
            // 
            this.списъкНаВсичкиПостиженияToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.списъкНаВсичкиПостиженияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.списъкНаВсичкиПостиженияToolStripMenuItem.Name = "списъкНаВсичкиПостиженияToolStripMenuItem";
            this.списъкНаВсичкиПостиженияToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.списъкНаВсичкиПостиженияToolStripMenuItem.Text = "Списък на всички постижения";
            this.списъкНаВсичкиПостиженияToolStripMenuItem.Click += new System.EventHandler(this.списъкНаВсичкиПостиженияToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиПредметToolStripMenuItem,
            this.списъкПредметиToolStripMenuItem});
            this.scoreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.scoreToolStripMenuItem.Text = "Дисцплини";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // добавиПредметToolStripMenuItem
            // 
            this.добавиПредметToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.добавиПредметToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.добавиПредметToolStripMenuItem.Name = "добавиПредметToolStripMenuItem";
            this.добавиПредметToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.добавиПредметToolStripMenuItem.Text = "Добави дисциплина";
            this.добавиПредметToolStripMenuItem.Click += new System.EventHandler(this.добавиПредметToolStripMenuItem_Click);
            // 
            // списъкПредметиToolStripMenuItem
            // 
            this.списъкПредметиToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.списъкПредметиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.списъкПредметиToolStripMenuItem.Name = "списъкПредметиToolStripMenuItem";
            this.списъкПредметиToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.списъкПредметиToolStripMenuItem.Text = "Списък дисциплини";
            this.списъкПредметиToolStripMenuItem.Click += new System.EventHandler(this.списъкПредметиToolStripMenuItem_Click);
            // 
            // състезанияToolStripMenuItem
            // 
            this.състезанияToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.състезанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиСъстезаниеToolStripMenuItem,
            this.списъкСъстезанияToolStripMenuItem});
            this.състезанияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.състезанияToolStripMenuItem.Name = "състезанияToolStripMenuItem";
            this.състезанияToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.състезанияToolStripMenuItem.Text = "Състезания";
            this.състезанияToolStripMenuItem.Click += new System.EventHandler(this.състезанияToolStripMenuItem_Click);
            // 
            // добавиСъстезаниеToolStripMenuItem
            // 
            this.добавиСъстезаниеToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.добавиСъстезаниеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.добавиСъстезаниеToolStripMenuItem.Name = "добавиСъстезаниеToolStripMenuItem";
            this.добавиСъстезаниеToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.добавиСъстезаниеToolStripMenuItem.Text = "Добави състезание";
            this.добавиСъстезаниеToolStripMenuItem.Click += new System.EventHandler(this.добавиСъстезаниеToolStripMenuItem_Click);
            // 
            // списъкСъстезанияToolStripMenuItem
            // 
            this.списъкСъстезанияToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.списъкСъстезанияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.списъкСъстезанияToolStripMenuItem.Name = "списъкСъстезанияToolStripMenuItem";
            this.списъкСъстезанияToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.списъкСъстезанияToolStripMenuItem.Text = "Списък състезания";
            this.списъкСъстезанияToolStripMenuItem.Click += new System.EventHandler(this.списъкСъстезанияToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Date,
            this.pictureDataGridViewImageColumn,
            this.Постижения});
            this.dataGridView1.DataSource = this.stundetmodelBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(784, 512);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 48.85786F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 48.85786F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 161;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 48.85786F;
            this.Date.HeaderText = "Клас";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 161;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.FillWeight = 304.5685F;
            this.pictureDataGridViewImageColumn.HeaderText = "Снимка";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Width = 120;
            // 
            // Постижения
            // 
            this.Постижения.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Постижения.FillWeight = 48.85786F;
            this.Постижения.HeaderText = "Постижения";
            this.Постижения.Name = "Постижения";
            this.Постижения.ReadOnly = true;
            this.Постижения.Width = 161;
            // 
            // VazovNetwork
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VazovNetwork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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