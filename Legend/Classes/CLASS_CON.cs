using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legend.Classes
{
    class CLASS_CON
    {
        public static SqlConnection conn = null;

        public static void Open()
        {
            try
            {
                conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Legend_DB;Trusted_Connection = True; Integrated Security = True");
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void Close()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
