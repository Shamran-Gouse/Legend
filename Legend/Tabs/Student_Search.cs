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
    public partial class Student_Search : UserControl
    {
        private static Student_Search _instance;

        public static Student_Search Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Student_Search();

                return _instance;
            }
        }

        public Student_Search()
        {
            InitializeComponent();
            ClearFields(); // to clear fields
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txt_Search.Text);

                CLASS_STUDENT Student = new CLASS_STUDENT();
                Student.Search(ID);

                txt_Name_Initial.Text = Student.Name_Intial;
                txt_Full_Name.Text = Student.Full_Name;
                txt_Address.Text = Student.Address;
                txt_School.Text = Student.School;
                txt_Contact_No.Text = Student.Contact_No;
                txt_Email.Text = Student.Email;
                Dropdown_Gender.Text = Student.Gender;
                Dropdown_Grade.Text = Student.Grade;
                Dropdown_Medium.Text = Student.Medium;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearFields() // to clear fields
        {
            txt_Search.Text = "";
            txt_Name_Initial.Text = "";
            txt_Full_Name.Text = "";
            txt_Address.Text = "";
            txt_School.Text = "";
            txt_Contact_No.Text = "";
            txt_Email.Text = "";
            Dropdown_Gender.SelectedIndex = 0;
            Dropdown_Grade.SelectedIndex = 0;
            Dropdown_Medium.SelectedIndex = 0;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields(); // to clear fields
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "" |txt_Name_Initial.Text == "" | txt_Full_Name.Text == "" | txt_Address.Text == "" | txt_School.Text == "" | txt_Contact_No.Text == "" | txt_Email.Text == "" | Dropdown_Gender.SelectedIndex == 0 | Dropdown_Grade.SelectedIndex == 0 | Dropdown_Medium.SelectedIndex == 0)
            {
                MessageBox.Show("Please Enter Required Details");
            }
            else
            {
                CLASS_STUDENT Student = new CLASS_STUDENT();

                int ID = Convert.ToInt32(txt_Search.Text);
                Student.Name_Intial = txt_Name_Initial.Text;
                Student.Full_Name = txt_Full_Name.Text;
                Student.Address = txt_Address.Text;
                Student.School = txt_School.Text;
                Student.Contact_No = txt_Contact_No.Text;
                Student.Email = txt_Email.Text;
                Student.Gender = Dropdown_Gender.Text;
                Student.Grade = Dropdown_Grade.Text;
                Student.Medium = Dropdown_Medium.Text;

                Student.Update(ID); // Update Method Method
                ClearFields(); // to clear fields
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Please Enter Student Id");
            }
            else
            {
                int ID = Convert.ToInt32(txt_Search.Text);

                CLASS_STUDENT Student = new CLASS_STUDENT();
                Student.Delete(ID); // Update Method Method
                ClearFields(); // to clear fields
            }
            
        }
    }
}
