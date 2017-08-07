namespace Legend.Tabs
{
    partial class Student
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
            this.Tab_Register = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_Student = new System.Windows.Forms.Panel();
            this.Line = new Bunifu.Framework.UI.BunifuSeparator();
            this.Tab_Search = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Tab_View = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // Tab_Register
            // 
            this.Tab_Register.AutoSize = true;
            this.Tab_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Register.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab_Register.Location = new System.Drawing.Point(68, 96);
            this.Tab_Register.Name = "Tab_Register";
            this.Tab_Register.Size = new System.Drawing.Size(66, 16);
            this.Tab_Register.TabIndex = 0;
            this.Tab_Register.Text = "REGISTER";
            this.Tab_Register.Click += new System.EventHandler(this.Tab_Register_Click);
            // 
            // panel_Student
            // 
            this.panel_Student.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Student.Location = new System.Drawing.Point(0, 131);
            this.panel_Student.Name = "panel_Student";
            this.panel_Student.Size = new System.Drawing.Size(830, 515);
            this.panel_Student.TabIndex = 1;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.Transparent;
            this.Line.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.Line.LineThickness = 4;
            this.Line.Location = new System.Drawing.Point(58, 113);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(79, 12);
            this.Line.TabIndex = 2;
            this.Line.Transparency = 255;
            this.Line.Vertical = false;
            // 
            // Tab_Search
            // 
            this.Tab_Search.AutoSize = true;
            this.Tab_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab_Search.Location = new System.Drawing.Point(175, 96);
            this.Tab_Search.Name = "Tab_Search";
            this.Tab_Search.Size = new System.Drawing.Size(59, 16);
            this.Tab_Search.TabIndex = 3;
            this.Tab_Search.Text = "SEARCH";
            this.Tab_Search.Click += new System.EventHandler(this.Tab_Search_Click);
            // 
            // Tab_View
            // 
            this.Tab_View.AutoSize = true;
            this.Tab_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_View.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab_View.Location = new System.Drawing.Point(278, 96);
            this.Tab_View.Name = "Tab_View";
            this.Tab_View.Size = new System.Drawing.Size(40, 16);
            this.Tab_View.TabIndex = 4;
            this.Tab_View.Text = "VIEW";
            this.Tab_View.Click += new System.EventHandler(this.Tab_View_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(314, 44);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(122, 32);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "STUDENT";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Tab_View);
            this.Controls.Add(this.Tab_Search);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.panel_Student);
            this.Controls.Add(this.Tab_Register);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(830, 646);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Tab_Register;
        private System.Windows.Forms.Panel panel_Student;
        private Bunifu.Framework.UI.BunifuSeparator Line;
        private Bunifu.Framework.UI.BunifuCustomLabel Tab_Search;
        private Bunifu.Framework.UI.BunifuCustomLabel Tab_View;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
