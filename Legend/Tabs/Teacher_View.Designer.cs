namespace Legend.Tabs
{
    partial class Teacher_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_View));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Search = new Bunifu.Framework.UI.BunifuTextbox();
            this.DataGrid_Teacher = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Teacher)).BeginInit();
            this.SuspendLayout();
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
            this.txt_Search.TabIndex = 4;
            this.txt_Search.text = "";
            this.toolTip1.SetToolTip(this.txt_Search, "Enter Teacher Details to Search");
            this.txt_Search.OnTextChange += new System.EventHandler(this.txt_Search_OnTextChange);
            // 
            // DataGrid_Teacher
            // 
            this.DataGrid_Teacher.AllowUserToAddRows = false;
            this.DataGrid_Teacher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Teacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Teacher.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Teacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Teacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Teacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Teacher.DoubleBuffered = true;
            this.DataGrid_Teacher.EnableHeadersVisualStyles = false;
            this.DataGrid_Teacher.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DataGrid_Teacher.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_Teacher.Location = new System.Drawing.Point(47, 44);
            this.DataGrid_Teacher.Name = "DataGrid_Teacher";
            this.DataGrid_Teacher.ReadOnly = true;
            this.DataGrid_Teacher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Teacher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Teacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Teacher.Size = new System.Drawing.Size(744, 359);
            this.DataGrid_Teacher.TabIndex = 3;
            // 
            // Teacher_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.DataGrid_Teacher);
            this.Name = "Teacher_View";
            this.Size = new System.Drawing.Size(830, 515);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Teacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_Teacher;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
