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
    public partial class Student_Register : UserControl
    {
        private static Student_Register _instance;

        public static Student_Register Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Student_Register();

                return _instance;
            }
        }

        public Student_Register()
        {
            InitializeComponent();
        }
    }
}
