namespace Legend.Tabs
{
    partial class Student_View
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_View));
            this.DataGrid_Student = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Student
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Student.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Student.DoubleBuffered = true;
            this.DataGrid_Student.EnableHeadersVisualStyles = false;
            this.DataGrid_Student.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGrid_Student.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DataGrid_Student.Location = new System.Drawing.Point(47, 92);
            this.DataGrid_Student.Name = "DataGrid_Student";
            this.DataGrid_Student.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Student.Size = new System.Drawing.Size(744, 311);
            this.DataGrid_Student.TabIndex = 1;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(243, 440);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(344, 42);
            this.bunifuTextbox1.TabIndex = 2;
            this.bunifuTextbox1.text = "Enter Student Details to Search";
            // 
            // Student_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.DataGrid_Student);
            this.Name = "Student_View";
            this.Size = new System.Drawing.Size(830, 515);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_Student;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
    }
}
