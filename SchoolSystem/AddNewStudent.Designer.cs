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
            this.label7 = new System.Windows.Forms.Label();
            this.StudentImage = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Клас";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(44, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Picture";
            // 
            // StudentImage
            // 
            this.StudentImage.Location = new System.Drawing.Point(207, 189);
            this.StudentImage.Margin = new System.Windows.Forms.Padding(4);
            this.StudentImage.Name = "StudentImage";
            this.StudentImage.Size = new System.Drawing.Size(333, 142);
            this.StudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentImage.TabIndex = 13;
            this.StudentImage.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(207, 339);
            this.Upload.Margin = new System.Windows.Forms.Padding(4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(333, 34);
            this.Upload.TabIndex = 14;
            this.Upload.Text = "Качи снимка";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(418, 471);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(122, 42);
            this.AddStudent.TabIndex = 15;
            this.AddStudent.Text = "Добави";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(48, 471);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(122, 42);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Откажи";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(207, 56);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(331, 26);
            this.NameBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пълно Име";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // classTextBox
            // 
            this.classTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.classTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classTextBox.Location = new System.Drawing.Point(207, 132);
            this.classTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(331, 26);
            this.classTextBox.TabIndex = 18;
            this.classTextBox.TextChanged += new System.EventHandler(this.classTextBox_TextChanged);
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 574);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.StudentImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавене на ученик";
            this.Load += new System.EventHandler(this.AddNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox StudentImage;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox classTextBox;
    }
}