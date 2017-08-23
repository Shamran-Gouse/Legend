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
    public partial class Teacher_Register : UserControl
    {
        private static Teacher_Register _instance;

        public static Teacher_Register Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Teacher_Register();

                return _instance;
            }
        }

        public Teacher_Register()
        {
            InitializeComponent();

            ClearFields(); // to clear fields
        }

        private void ClearFields() // to clear fields
        {
            txt_Name_Initial.Text = "";
            txt_Full_Name.Text = "";
            txt_Address.Text = "";
            txt_Contact_No.Text = "";
            txt_Email.Text = "";
            Dropdown_Gender.SelectedIndex = 0;
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Name_Initial.Text == "" | txt_Full_Name.Text == "" | txt_Address.Text == "" | txt_Contact_No.Text == "" | Dropdown_Gender.SelectedIndex == 0)
            {
                MessageBox.Show("Please Enter Required Details");
            }
            else
            {
                CLASS_TEACHER Teacher = new CLASS_TEACHER();
                Teacher.Name_Intial = txt_Name_Initial.Text;
                Teacher.Full_Name = txt_Full_Name.Text;
                Teacher.Address = txt_Address.Text;
                Teacher.Contact_No = txt_Contact_No.Text;
                Teacher.Email = txt_Email.Text;
                Teacher.Gender = Dropdown_Gender.Text;

                Teacher.Register(); // register Method
                ClearFields(); // to clear fields
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields(); // to clear fields
        }
    }
}
