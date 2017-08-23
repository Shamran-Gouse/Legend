using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legend.Classes
{
    class CLASS_TEACHER
    {
        private int id;

        private string name_intial;

        private string full_name;

        private string gender;

        private string address;

        private string contact_no;

        private string email;

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


        private int GetMaxID()
        {
            int MaxID = 0;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT MAX(T_ID) FROM Teacher", con))
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

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Teacher (T_ID, Name_Intial, Full_Name, Gender, Teacher_Address, Contact_No, Email) VALUES ('" + (GetMaxID() + 1) + "', '" + name_intial + "', '" + full_name + "', '" + gender + "', '" + address + "', '" + contact_no + "', '" + email + "')", con))
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

                using (SqlCommand cmd = new SqlCommand("SELECT * From Teacher Where T_ID = '" + ID + "' ", con))
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
                                    contact_no = reader[5].ToString();
                                    email = reader[6].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Teacher ID Does Not Exist");
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

                using (SqlCommand cmd = new SqlCommand("UPDATE Teacher SET Name_Intial = '" + name_intial + "', Full_Name = '" + full_name + "', Gender = '" + gender + "', Teacher_Address = '" + address + "', Contact_No = '" + contact_no + "', Email = '" + email + "' WHERE (T_ID = '" + ID + "') ", con))
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

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Teacher WHERE T_ID = '" + ID + "'", con))
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
