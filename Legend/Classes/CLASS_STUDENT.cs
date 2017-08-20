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

        private string gender;

        private string address;

        private string school;

        private string contact_no;

        private string email;        

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


        private int GetMaxID()
        {
            int MaxID = 0;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM Student", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    MaxID = Convert.ToInt32(reader[0]);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        if (MaxID >= 0)
                            return MaxID;
                        else
                            return 0;
                    }
                }
            }
        }

        public void Register()
        {

            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Student (ID, Name_Intial, Full_Name, Gender, Student_Address, School, Contact_No, Email, Grade, Medium) VALUES ('" + (GetMaxID() + 1) + "', '" + name_intial + "', '" + full_name + "', '" + gender + "', '" + address + "', '" + school + "', '" + contact_no + "', '" + email + "', '" + grade + "', '" + medium + "')", con))
                    {
                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                            MessageBox.Show("Registered Successfully");
                        else
                            MessageBox.Show("Error Registering");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Search(int ID)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * From Student Where ID = '" + ID + "' ", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //id = Convert.ToInt32(reader[0]);
                                    name_intial = reader[1].ToString();
                                    full_name = reader[2].ToString();
                                    gender = reader[3].ToString();
                                    address = reader[4].ToString();
                                    school = reader[5].ToString();
                                    contact_no = reader[6].ToString();
                                    email = reader[7].ToString();
                                    grade = reader[8].ToString();
                                    medium = reader[9].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Student ID Does Not Exist");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        public void Update(int ID)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                con.Open();
                int result = 0;

                using (SqlCommand cmd = new SqlCommand("UPDATE Student SET Name_Intial = '" + name_intial + "', Full_Name = '" + full_name + "', Gender = '" + gender + "', Student_Address = '" + address + "', School = '" + school + "', Contact_No = '" + contact_no + "', Email = '" + email + "', Grade = '" + grade + "', Medium = '" + medium + "' WHERE (ID = '"+ ID +"') ", con))
                {
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (result == 1)
                        MessageBox.Show("Update Successfully");
                    else
                        MessageBox.Show("Error Updating");
                }
            }
        }

        public void Delete(int ID)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                con.Open();
                int result = 0;

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE ID = '"+ ID +"'", con))
                {
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    if (result == 1)
                        MessageBox.Show("Remove Successfully");
                    else
                        MessageBox.Show("Error Removing");
                }
            }
        }

    }
}
