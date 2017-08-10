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

        public Student_View()
        {
            InitializeComponent();
        }
    }
}
