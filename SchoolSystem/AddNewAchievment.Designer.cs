namespace VazovNetwork
{
    partial class AddNewAchievment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAchievment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentIdBox = new System.Windows.Forms.TextBox();
            this.explanBox = new System.Windows.Forms.TextBox();
            this.rewardBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.AddStudent = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CompetitionList = new System.Windows.Forms.ComboBox();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID на ученика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Състезание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дисциплина";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Информация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Награда";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Година";
            // 
            // studentIdBox
            // 
            this.studentIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentIdBox.Location = new System.Drawing.Point(231, 50);
            this.studentIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentIdBox.Name = "studentIdBox";
            this.studentIdBox.Size = new System.Drawing.Size(331, 26);
            this.studentIdBox.TabIndex = 18;
            // 
            // explanBox
            // 
            this.explanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.explanBox.Location = new System.Drawing.Point(231, 298);
            this.explanBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explanBox.Name = "explanBox";
            this.explanBox.Size = new System.Drawing.Size(331, 26);
            this.explanBox.TabIndex = 19;
            // 
            // rewardBox
            // 
            this.rewardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardBox.Location = new System.Drawing.Point(231, 360);
            this.rewardBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rewardBox.Name = "rewardBox";
            this.rewardBox.Size = new System.Drawing.Size(331, 26);
            this.rewardBox.TabIndex = 20;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearBox.Location = new System.Drawing.Point(231, 240);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(331, 22);
            this.yearBox.TabIndex = 21;
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(441, 462);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(123, 42);
            this.AddStudent.TabIndex = 24;
            this.AddStudent.Text = "Добави";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddAchievment_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(24, 462);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(122, 42);
            this.Cancel.TabIndex = 25;
            this.Cancel.Text = "Откажи";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SubjectList
            // 
            this.SubjectList.DataSource = this.subjectBindingSource1;
            this.SubjectList.DisplayMember = "Name";
            this.SubjectList.FormattingEnabled = true;
            this.SubjectList.Location = new System.Drawing.Point(231, 124);
            this.SubjectList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(331, 27);
            this.SubjectList.TabIndex = 26;
            this.SubjectList.ValueMember = "Id";
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataSource = typeof(Db.Subject);
            // 
            // CompetitionList
            // 
            this.CompetitionList.DataSource = this.competitionBindingSource;
            this.CompetitionList.DisplayMember = "Type";
            this.CompetitionList.FormattingEnabled = true;
            this.CompetitionList.Location = new System.Drawing.Point(231, 183);
            this.CompetitionList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompetitionList.Name = "CompetitionList";
            this.CompetitionList.Size = new System.Drawing.Size(331, 27);
            this.CompetitionList.TabIndex = 27;
            this.CompetitionList.ValueMember = "Id";
            // 
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataSource = typeof(Db.Competition);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Db.Subject);
            // 
            // AddNewAchievment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 522);
            this.Controls.Add(this.CompetitionList);
            this.Controls.Add(this.SubjectList);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.rewardBox);
            this.Controls.Add(this.explanBox);
            this.Controls.Add(this.studentIdBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewAchievment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавяне на постижение";
            this.Load += new System.EventHandler(this.AddNewAchievment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentIdBox;
        private System.Windows.Forms.TextBox explanBox;
        private System.Windows.Forms.TextBox rewardBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox SubjectList;
        private System.Windows.Forms.ComboBox CompetitionList;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource;
    }
}