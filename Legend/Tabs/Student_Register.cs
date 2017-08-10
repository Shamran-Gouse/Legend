using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Legend.Classes;

namespace Legend.Tabs
{
    public partial class Student_Register : UserControl
    {
        private static Student_Register _instance;

        public static Student_Register Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Student_Register();

                return _instance;
            }
        }

        public Student_Register()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Name_Initial.Text == "" | txt_Full_Name.Text == "" | txt_Address.Text == "" | txt_School.Text == "" | txt_Contact_No.Text == "" | txt_Email.Text == "" | Dropdown_Gender.selectedIndex == -1 | Dropdown_Grade.selectedIndex == 0 | Dropdown_Medium.selectedIndex == -1)
            {
                MessageBox.Show("Please Enter Required Details");
            }
            else
            {
                CLASS_STUDENT Student = new CLASS_STUDENT();
                Student.Name_Intial = txt_Name_Initial.Text;
                Student.Full_Name = txt_Full_Name.Text;
                Student.Address = txt_Address.Text;
                Student.School = txt_School.Text;
                Student.Contact_No = txt_Contact_No.Text;
                Student.Email = txt_Email.Text;
                Student.Gender = Dropdown_Gender.selectedValue;
                Student.Grade = Dropdown_Grade.selectedValue;
                Student.Medium = Dropdown_Medium.selectedValue;

                Student.Register();
                ClearFields();

                MessageBox.Show("Registered Successfully");
            }
        }

        private void ClearFields()
        {
            txt_Name_Initial.Text = "";
            txt_Full_Name.Text = "";
            txt_Address.Text = "";
            txt_School.Text = "";
            txt_Contact_No.Text = "";
            txt_Email.Text = "";
            Dropdown_Gender.selectedIndex = 0;
            Dropdown_Grade.selectedIndex = 0;
            Dropdown_Medium.selectedIndex = 0;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
