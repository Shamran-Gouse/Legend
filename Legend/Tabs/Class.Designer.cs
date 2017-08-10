namespace Legend.Tabs
{
    partial class Class
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Tab_View = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Tab_Search = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Line = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_Student = new System.Windows.Forms.Panel();
            this.Tab_Create = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(307, 41);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 32);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "CLASS";
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
            this.Tab_View.TabIndex = 10;
            this.Tab_View.Text = "VIEW";
            this.Tab_View.Click += new System.EventHandler(this.Tab_View_Click);
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
            this.Tab_Search.TabIndex = 9;
            this.Tab_Search.Text = "SEARCH";
            this.Tab_Search.Click += new System.EventHandler(this.Tab_Search_Click);
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
            this.Line.TabIndex = 8;
            this.Line.Transparency = 255;
            this.Line.Vertical = false;
            // 
            // panel_Student
            // 
            this.panel_Student.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Student.Location = new System.Drawing.Point(0, 131);
            this.panel_Student.Name = "panel_Student";
            this.panel_Student.Size = new System.Drawing.Size(830, 515);
            this.panel_Student.TabIndex = 7;
            // 
            // Tab_Create
            // 
            this.Tab_Create.AutoSize = true;
            this.Tab_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Create.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab_Create.Location = new System.Drawing.Point(68, 96);
            this.Tab_Create.Name = "Tab_Create";
            this.Tab_Create.Size = new System.Drawing.Size(56, 16);
            this.Tab_Create.TabIndex = 6;
            this.Tab_Create.Text = "CREATE";
            this.Tab_Create.Click += new System.EventHandler(this.Tab_Create_Click);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Tab_View);
            this.Controls.Add(this.Tab_Search);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.panel_Student);
            this.Controls.Add(this.Tab_Create);
            this.Name = "Class";
            this.Size = new System.Drawing.Size(830, 646);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Tab_View;
        private Bunifu.Framework.UI.BunifuCustomLabel Tab_Search;
        private Bunifu.Framework.UI.BunifuSeparator Line;
        private System.Windows.Forms.Panel panel_Student;
        private Bunifu.Framework.UI.BunifuCustomLabel Tab_Create;
    }
}
