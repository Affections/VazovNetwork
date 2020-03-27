namespace VazovNetwork
{
    partial class AddNewCompetition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCompetition));
            this.Cancel = new System.Windows.Forms.Button();
            this.AddCompetition = new System.Windows.Forms.Button();
            this.competitionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(27, 148);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(111, 47);
            this.Cancel.TabIndex = 31;
            this.Cancel.Text = "Откажи";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddCompetition
            // 
            this.AddCompetition.Location = new System.Drawing.Point(519, 148);
            this.AddCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCompetition.Name = "AddCompetition";
            this.AddCompetition.Size = new System.Drawing.Size(111, 47);
            this.AddCompetition.TabIndex = 30;
            this.AddCompetition.Text = "Добави";
            this.AddCompetition.UseVisualStyleBackColor = true;
            this.AddCompetition.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // competitionBox
            // 
            this.competitionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.competitionBox.Location = new System.Drawing.Point(255, 63);
            this.competitionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.competitionBox.Name = "competitionBox";
            this.competitionBox.Size = new System.Drawing.Size(373, 26);
            this.competitionBox.TabIndex = 29;
            this.competitionBox.TextChanged += new System.EventHandler(this.subjectBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Състезание";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddNewCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 224);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddCompetition);
            this.Controls.Add(this.competitionBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewCompetition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавяне на състезание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddCompetition;
        private System.Windows.Forms.TextBox competitionBox;
        private System.Windows.Forms.Label label1;
    }
}