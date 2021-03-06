﻿namespace Legend.Tabs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_View));
            this.DataGrid_Student = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_Search = new Bunifu.Framework.UI.BunifuTextbox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Student
            // 
            this.DataGrid_Student.AllowUserToAddRows = false;
            this.DataGrid_Student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Student.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Student.DoubleBuffered = true;
            this.DataGrid_Student.EnableHeadersVisualStyles = false;
            this.DataGrid_Student.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DataGrid_Student.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_Student.Location = new System.Drawing.Point(47, 44);
            this.DataGrid_Student.Name = "DataGrid_Student";
            this.DataGrid_Student.ReadOnly = true;
            this.DataGrid_Student.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Student.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Student.Size = new System.Drawing.Size(744, 359);
            this.DataGrid_Student.TabIndex = 1;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.Silver;
            this.txt_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Search.BackgroundImage")));
            this.txt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Search.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Search.Icon")));
            this.txt_Search.Location = new System.Drawing.Point(243, 440);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(344, 42);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.text = "";
            this.toolTip1.SetToolTip(this.txt_Search, "Enter Student Details to Search");
            this.txt_Search.OnTextChange += new System.EventHandler(this.txt_Search_OnTextChange);
            // 
            // Student_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.DataGrid_Student);
            this.Name = "Student_View";
            this.Size = new System.Drawing.Size(830, 515);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_Student;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
