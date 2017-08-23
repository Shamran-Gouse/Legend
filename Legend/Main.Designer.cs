namespace Legend
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Header = new System.Windows.Forms.Panel();
            this.Minimize_Window = new System.Windows.Forms.PictureBox();
            this.Close_Window = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Teacher = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Class = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Student = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Window)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Window)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_Header.Controls.Add(this.Minimize_Window);
            this.panel_Header.Controls.Add(this.Close_Window);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1011, 44);
            this.panel_Header.TabIndex = 0;
            // 
            // Minimize_Window
            // 
            this.Minimize_Window.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_Window.Image")));
            this.Minimize_Window.Location = new System.Drawing.Point(946, 3);
            this.Minimize_Window.Name = "Minimize_Window";
            this.Minimize_Window.Size = new System.Drawing.Size(28, 32);
            this.Minimize_Window.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize_Window.TabIndex = 1;
            this.Minimize_Window.TabStop = false;
            this.Minimize_Window.Click += new System.EventHandler(this.Minimize_Window_Click);
            // 
            // Close_Window
            // 
            this.Close_Window.Image = ((System.Drawing.Image)(resources.GetObject("Close_Window.Image")));
            this.Close_Window.Location = new System.Drawing.Point(978, 3);
            this.Close_Window.Name = "Close_Window";
            this.Close_Window.Size = new System.Drawing.Size(28, 32);
            this.Close_Window.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Window.TabIndex = 0;
            this.Close_Window.TabStop = false;
            this.Close_Window.Click += new System.EventHandler(this.Close_Window_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuFlatButton7);
            this.panel2.Controls.Add(this.bunifuFlatButton4);
            this.panel2.Controls.Add(this.bunifuFlatButton6);
            this.panel2.Controls.Add(this.bunifuFlatButton5);
            this.panel2.Controls.Add(this.Btn_Teacher);
            this.panel2.Controls.Add(this.Btn_Class);
            this.panel2.Controls.Add(this.Btn_Student);
            this.panel2.Controls.Add(this.panel_Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 646);
            this.panel2.TabIndex = 1;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "    Student";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 30;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 35D;
            this.bunifuFlatButton7.IsTab = true;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 458);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(181, 48);
            this.bunifuFlatButton7.TabIndex = 7;
            this.bunifuFlatButton7.Text = "    Student";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "    Student";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 30;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 35D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 410);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(181, 48);
            this.bunifuFlatButton4.TabIndex = 4;
            this.bunifuFlatButton4.Text = "    Student";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "    Student";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 30;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 35D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 362);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(181, 48);
            this.bunifuFlatButton6.TabIndex = 6;
            this.bunifuFlatButton6.Text = "    Student";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "    Student";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 30;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 35D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 314);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(181, 48);
            this.bunifuFlatButton5.TabIndex = 5;
            this.bunifuFlatButton5.Text = "    Student";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Teacher
            // 
            this.Btn_Teacher.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Btn_Teacher.BackColor = System.Drawing.Color.White;
            this.Btn_Teacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Teacher.BorderRadius = 0;
            this.Btn_Teacher.ButtonText = "    Teacher";
            this.Btn_Teacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Teacher.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Teacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Teacher.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Teacher.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Teacher.Iconimage")));
            this.Btn_Teacher.Iconimage_right = null;
            this.Btn_Teacher.Iconimage_right_Selected = null;
            this.Btn_Teacher.Iconimage_Selected = null;
            this.Btn_Teacher.IconMarginLeft = 30;
            this.Btn_Teacher.IconMarginRight = 0;
            this.Btn_Teacher.IconRightVisible = true;
            this.Btn_Teacher.IconRightZoom = 0D;
            this.Btn_Teacher.IconVisible = true;
            this.Btn_Teacher.IconZoom = 45D;
            this.Btn_Teacher.IsTab = true;
            this.Btn_Teacher.Location = new System.Drawing.Point(0, 266);
            this.Btn_Teacher.Name = "Btn_Teacher";
            this.Btn_Teacher.Normalcolor = System.Drawing.Color.White;
            this.Btn_Teacher.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Btn_Teacher.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Teacher.selected = false;
            this.Btn_Teacher.Size = new System.Drawing.Size(181, 48);
            this.Btn_Teacher.TabIndex = 3;
            this.Btn_Teacher.Text = "    Teacher";
            this.Btn_Teacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Teacher.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Btn_Teacher.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Teacher.Click += new System.EventHandler(this.Btn_Teacher_Click);
            // 
            // Btn_Class
            // 
            this.Btn_Class.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Btn_Class.BackColor = System.Drawing.Color.White;
            this.Btn_Class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Class.BorderRadius = 0;
            this.Btn_Class.ButtonText = "    Class";
            this.Btn_Class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Class.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Class.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Class.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Class.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Class.Iconimage")));
            this.Btn_Class.Iconimage_right = null;
            this.Btn_Class.Iconimage_right_Selected = null;
            this.Btn_Class.Iconimage_Selected = null;
            this.Btn_Class.IconMarginLeft = 30;
            this.Btn_Class.IconMarginRight = 0;
            this.Btn_Class.IconRightVisible = true;
            this.Btn_Class.IconRightZoom = 0D;
            this.Btn_Class.IconVisible = true;
            this.Btn_Class.IconZoom = 45D;
            this.Btn_Class.IsTab = true;
            this.Btn_Class.Location = new System.Drawing.Point(0, 218);
            this.Btn_Class.Name = "Btn_Class";
            this.Btn_Class.Normalcolor = System.Drawing.Color.White;
            this.Btn_Class.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Btn_Class.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Class.selected = false;
            this.Btn_Class.Size = new System.Drawing.Size(181, 48);
            this.Btn_Class.TabIndex = 1;
            this.Btn_Class.Text = "    Class";
            this.Btn_Class.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Class.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Btn_Class.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Class.Click += new System.EventHandler(this.Btn_Class_Click);
            // 
            // Btn_Student
            // 
            this.Btn_Student.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Btn_Student.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Student.BorderRadius = 0;
            this.Btn_Student.ButtonText = "    Student";
            this.Btn_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Student.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Student.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Student.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Student.Iconimage")));
            this.Btn_Student.Iconimage_right = null;
            this.Btn_Student.Iconimage_right_Selected = null;
            this.Btn_Student.Iconimage_Selected = null;
            this.Btn_Student.IconMarginLeft = 30;
            this.Btn_Student.IconMarginRight = 0;
            this.Btn_Student.IconRightVisible = true;
            this.Btn_Student.IconRightZoom = 0D;
            this.Btn_Student.IconVisible = true;
            this.Btn_Student.IconZoom = 45D;
            this.Btn_Student.IsTab = true;
            this.Btn_Student.Location = new System.Drawing.Point(0, 170);
            this.Btn_Student.Name = "Btn_Student";
            this.Btn_Student.Normalcolor = System.Drawing.Color.White;
            this.Btn_Student.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Btn_Student.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Student.selected = true;
            this.Btn_Student.Size = new System.Drawing.Size(181, 48);
            this.Btn_Student.TabIndex = 2;
            this.Btn_Student.Text = "    Student";
            this.Btn_Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Student.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Btn_Student.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Student.Click += new System.EventHandler(this.Btn_Student_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.White;
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(181, 170);
            this.panel_Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(181, 44);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(830, 646);
            this.panel_Body.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1011, 690);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 25);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Window)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Window)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_Header;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Teacher;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Class;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Student;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.PictureBox Close_Window;
        private System.Windows.Forms.PictureBox Minimize_Window;
    }
}

