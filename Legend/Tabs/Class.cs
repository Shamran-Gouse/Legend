using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legend.Tabs
{
    public partial class Class : UserControl
    {
        private static Class _instance;

        public static Class Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Class();

                return _instance;
            }
        }

        public Class()
        {
            InitializeComponent();
        }

        private void Tab_Create_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_Create.Width;
            Line.Left = Tab_Create.Left;
        }

        private void Tab_Search_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_Search.Width;
            Line.Left = Tab_Search.Left;
        }

        private void Tab_View_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_View.Width;
            Line.Left = Tab_View.Left;
        }
    }
}
