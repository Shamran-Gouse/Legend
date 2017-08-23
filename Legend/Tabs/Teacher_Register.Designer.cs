namespace Legend.Tabs
{
    partial class Teacher_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Register));
            this.Btn_Register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Clear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Dropdown_Gender = new System.Windows.Forms.ComboBox();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Contact_No = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Full_Name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Name_Initial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // Btn_Register
            // 
            this.Btn_Register.ActiveBorderThickness = 1;
            this.Btn_Register.ActiveCornerRadius = 1;
            this.Btn_Register.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Register.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Register.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Register.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Register.BackgroundImage")));
            this.Btn_Register.ButtonText = "Register";
            this.Btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Register.IdleBorderThickness = 1;
            this.Btn_Register.IdleCornerRadius = 1;
            this.Btn_Register.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Register.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.Btn_Register.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Register.Location = new System.Drawing.Point(697, 454);
            this.Btn_Register.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(110, 47);
            this.Btn_Register.TabIndex = 117;
            this.Btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.ActiveBorderThickness = 1;
            this.Btn_Clear.ActiveCornerRadius = 1;
            this.Btn_Clear.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Clear.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Clear.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Clear.BackgroundImage")));
            this.Btn_Clear.ButtonText = "Clear";
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Clear.IdleBorderThickness = 1;
            this.Btn_Clear.IdleCornerRadius = 1;
            this.Btn_Clear.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Clear.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.Btn_Clear.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Clear.Location = new System.Drawing.Point(577, 454);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(110, 47);
            this.Btn_Clear.TabIndex = 116;
            this.Btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Dropdown_Gender
            // 
            this.Dropdown_Gender.BackColor = System.Drawing.Color.DodgerBlue;
            this.Dropdown_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dropdown_Gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Gender.FormattingEnabled = true;
            this.Dropdown_Gender.ItemHeight = 21;
            this.Dropdown_Gender.Items.AddRange(new object[] {
            "Gender :",
            "Male",
            "Female"});
            this.Dropdown_Gender.Location = new System.Drawing.Point(505, 140);
            this.Dropdown_Gender.Name = "Dropdown_Gender";
            this.Dropdown_Gender.Size = new System.Drawing.Size(217, 29);
            this.Dropdown_Gender.TabIndex = 119;
            // 
            // txt_Email
            // 
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Email.HintText = "Email :";
            this.txt_Email.isPassword = false;
            this.txt_Email.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Email.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txt_Email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Email.LineThickness = 3;
            this.txt_Email.Location = new System.Drawing.Point(105, 370);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(617, 33);
            this.txt_Email.TabIndex = 115;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Contact_No
            // 
            this.txt_Contact_No.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Contact_No.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Contact_No.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Contact_No.HintText = "Contact No :";
            this.txt_Contact_No.isPassword = false;
            this.txt_Contact_No.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Contact_No.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txt_Contact_No.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Contact_No.LineThickness = 3;
            this.txt_Contact_No.Location = new System.Drawing.Point(105, 312);
            this.txt_Contact_No.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contact_No.Name = "txt_Contact_No";
            this.txt_Contact_No.Size = new System.Drawing.Size(617, 33);
            this.txt_Contact_No.TabIndex = 114;
            this.txt_Contact_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Address
            // 
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Address.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Address.HintText = "Address :";
            this.txt_Address.isPassword = false;
            this.txt_Address.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Address.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txt_Address.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Address.LineThickness = 3;
            this.txt_Address.Location = new System.Drawing.Point(105, 254);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(617, 33);
            this.txt_Address.TabIndex = 112;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Full_Name
            // 
            this.txt_Full_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Full_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Full_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Full_Name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Full_Name.HintText = "Full Name :";
            this.txt_Full_Name.isPassword = false;
            this.txt_Full_Name.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Full_Name.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txt_Full_Name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Full_Name.LineThickness = 3;
            this.txt_Full_Name.Location = new System.Drawing.Point(105, 194);
            this.txt_Full_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Full_Name.Name = "txt_Full_Name";
            this.txt_Full_Name.Size = new System.Drawing.Size(617, 33);
            this.txt_Full_Name.TabIndex = 111;
            this.txt_Full_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Name_Initial
            // 
            this.txt_Name_Initial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name_Initial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name_Initial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Name_Initial.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Name_Initial.HintText = "Name with Initial :";
            this.txt_Name_Initial.isPassword = false;
            this.txt_Name_Initial.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Name_Initial.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txt_Name_Initial.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Name_Initial.LineThickness = 3;
            this.txt_Name_Initial.Location = new System.Drawing.Point(105, 136);
            this.txt_Name_Initial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name_Initial.Name = "txt_Name_Initial";
            this.txt_Name_Initial.Size = new System.Drawing.Size(379, 33);
            this.txt_Name_Initial.TabIndex = 110;
            this.txt_Name_Initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Teacher_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Dropdown_Gender);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Contact_No);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Full_Name);
            this.Controls.Add(this.txt_Name_Initial);
            this.Name = "Teacher_Register";
            this.Size = new System.Drawing.Size(830, 515);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Register;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Clear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox Dropdown_Gender;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Contact_No;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Address;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Full_Name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Name_Initial;
    }
}
