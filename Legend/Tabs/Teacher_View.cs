using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legend.Tabs
{
    public partial class Teacher_View : UserControl
    {
        private static Teacher_View _instance;

        public static Teacher_View Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Teacher_View();

                return _instance;
            }
        }

        static Bunifu.Framework.UI.BunifuCustomDataGrid grid;

        public Teacher_View()
        {
            InitializeComponent();

            grid = DataGrid_Teacher;
            Search();
        }

        public static void Search()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT T_ID AS ID, Name_Intial AS Name, Gender AS Gender, Teacher_Address As Address, Contact_No As Contact_No, Email FROM Teacher", con))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    DataTable DT = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DA.Fill(DT);
                    grid.DataSource = DT;
                }
            }
        }

        private void txt_Search_OnTextChange(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT T_ID AS ID, Name_Intial AS Name, Gender AS Gender, Teacher_Address As Address, Contact_No As Contact_No, Email FROM Teacher WHERE T_ID LIKE ('%" + txt_Search.text + "%') OR Name_Intial LIKE ('%" + txt_Search.text + "%') OR Gender LIKE ('%" + txt_Search.text + "%') OR Teacher_Address LIKE ('%" + txt_Search.text + "%') OR Contact_No LIKE ('%" + txt_Search.text + "%') OR Email LIKE ('%" + txt_Search.text + "%')", con))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    DataTable DT = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DA.Fill(DT);
                    grid.DataSource = DT;

                }
            }
        }
    }
}
