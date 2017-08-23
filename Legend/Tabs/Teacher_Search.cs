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
    public partial class Teacher_Search : UserControl
    {
        private static Teacher_Search _instance;

        public static Teacher_Search Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Teacher_Search();

                return _instance;
            }
        }

        public Teacher_Search()
        {
            InitializeComponent();

            ClearFields(); // to clear fields
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txt_Search.Text);

                CLASS_TEACHER Teacher = new CLASS_TEACHER();
                Teacher.Search(ID);

                txt_Name_Initial.Text = Teacher.Name_Intial;
                txt_Full_Name.Text = Teacher.Full_Name;
                txt_Address.Text = Teacher.Address;
                txt_Contact_No.Text = Teacher.Contact_No;
                txt_Email.Text = Teacher.Email;
                Dropdown_Gender.Text = Teacher.Gender;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields(); // to clear fields
        }

        private void ClearFields() // to clear fields
        {
            txt_Search.Text = "";
            txt_Name_Initial.Text = "";
            txt_Full_Name.Text = "";
            txt_Address.Text = "";
            txt_Contact_No.Text = "";
            txt_Email.Text = "";
            Dropdown_Gender.SelectedIndex = 0;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "" | txt_Name_Initial.Text == "" | txt_Full_Name.Text == "" | txt_Address.Text == "" | txt_Contact_No.Text == "" | Dropdown_Gender.SelectedIndex == 0)
            {
                MessageBox.Show("Please Enter Required Details");
            }
            else
            {
                CLASS_TEACHER Teacher = new CLASS_TEACHER();

                int ID = Convert.ToInt32(txt_Search.Text);
                Teacher.Name_Intial = txt_Name_Initial.Text;
                Teacher.Full_Name = txt_Full_Name.Text;
                Teacher.Address = txt_Address.Text;
                Teacher.Contact_No = txt_Contact_No.Text;
                Teacher.Email = txt_Email.Text;
                Teacher.Gender = Dropdown_Gender.Text;

                Teacher.Update(ID); // Update Method Method
                ClearFields(); // to clear fields
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Please Enter Teacher Id");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to Remove this User?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(txt_Search.Text);

                    CLASS_TEACHER Teacher = new CLASS_TEACHER();
                    Teacher.Delete(ID); // Update Method Method
                    ClearFields(); // to clear fields
                }
                else
                {
                    ClearFields();
                }
            }
        }
    }
}
