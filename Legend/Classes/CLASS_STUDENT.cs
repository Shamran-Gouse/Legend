using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legend.Classes
{
    class CLASS_STUDENT
    {
        private int id;

        private string name_intial;

        private string full_name;

        private string address;

        private string school;

        private string contact_no;

        private string email;

        private string gender;

        private string grade;

        private string medium;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name_Intial
        {
            get
            {
                return name_intial;
            }

            set
            {
                name_intial = value;
            }
        }

        public string Full_Name
        {
            get
            {
                return full_name;
            }

            set
            {
                full_name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public string Contact_No
        {
            get
            {
                return contact_no;
            }

            set
            {
                contact_no = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        public string Medium
        {
            get
            {
                return medium;
            }

            set
            {
                medium = value;
            }
        }


        public void Register()
        {
            try
            {
                CLASS_CON.Open();

                SqlCommand com = new SqlCommand("INSERT INTO [dbo].[Student]([Name_Intial],[Full_Name],[Gender],[Student_Address],[School],[Contact_No],[Email],[Grade],[Medium]) VALUES ('"+ name_intial +"', '"+ full_name +"', '"+ gender +"', '"+ address +"', '"+ school +"', '"+ contact_no +"', '"+ email +"', '"+ grade +"', '"+ medium +"')", CLASS_CON.conn);
                com.ExecuteNonQuery();
                
                CLASS_CON.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
