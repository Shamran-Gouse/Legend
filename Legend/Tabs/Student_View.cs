﻿using System;
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
    public partial class Student_View : UserControl
    {
        private static Student_View _instance;

        public static Student_View Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Student_View();

                return _instance;
            }
        }

        static Bunifu.Framework.UI.BunifuCustomDataGrid grid;

        public Student_View()
        {
            InitializeComponent();

            grid = DataGrid_Student;
            Search();
        }

        public static void Search()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Legend.Properties.Settings.Default.ConnectionString;
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT ID AS ID, Name_Intial AS Name, Gender AS Gender, Student_Address As Address, School, Contact_No As Contact_No, Grade, Medium FROM Student", con))
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

                    //DataGrid_Student.DataSource = DT;

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

                using (SqlCommand cmd = new SqlCommand("SELECT ID AS ID, Name_Intial AS Name, Gender AS Gender, Student_Address As Address, School, Contact_No As Contact_No, Grade, Medium FROM Student WHERE ID LIKE ('%" + txt_Search.text + "%') OR Name_Intial LIKE ('%" + txt_Search.text + "%') OR Gender LIKE ('%" + txt_Search.text + "%') OR Student_Address LIKE ('%" + txt_Search.text + "%') OR School LIKE ('%" + txt_Search.text + "%') OR Contact_No LIKE ('%" + txt_Search.text + "%') OR Grade LIKE ('%" + txt_Search.text + "%') OR Medium LIKE ('%" + txt_Search.text + "%')", con))
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

                    //DataGrid_Student.DataSource = DT;

                    grid.DataSource = DT;

                }
            }
        }

    }
}
