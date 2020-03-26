namespace VazovNetwork
{
    partial class AddNewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStudent));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentImage = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 86);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 7, 16, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(28, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Picture";
            // 
            // StudentImage
            // 
            this.StudentImage.Location = new System.Drawing.Point(138, 129);
            this.StudentImage.Name = "StudentImage";
            this.StudentImage.Size = new System.Drawing.Size(222, 97);
            this.StudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentImage.TabIndex = 13;
            this.StudentImage.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(138, 232);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(222, 23);
            this.Upload.TabIndex = 14;
            this.Upload.Text = "Качи снимка";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(279, 322);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(81, 29);
            this.AddStudent.TabIndex = 15;
            this.AddStudent.Text = "Добави";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(32, 322);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(81, 29);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Откажи";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(138, 38);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(222, 26);
            this.NameBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пълно Име";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 393);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.StudentImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewStudent";
            this.Text = "Добавене на ученик";
            this.Load += new System.EventHandler(this.AddNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox StudentImage;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
    }
}