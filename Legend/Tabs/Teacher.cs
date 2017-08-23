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
    public partial class Teacher : UserControl
    {
        private static Teacher _instance;

        public static Teacher Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Teacher();

                return _instance;
            }
        }

        public Teacher()
        {
            InitializeComponent();
        }

        private void Tab_Register_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_Register.Width;
            Line.Left = Tab_Register.Left;

            if (!panel_Student.Controls.Contains(Teacher_Register.Instance))
            {
                panel_Student.Controls.Add(Teacher_Register.Instance);
                Teacher_Register.Instance.Dock = DockStyle.Fill;
                Teacher_Register.Instance.BringToFront();
            }
            else
                Teacher_Register.Instance.BringToFront();

        }

        private void Tab_Search_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_Search.Width;
            Line.Left = Tab_Search.Left;

            if (!panel_Student.Controls.Contains(Teacher_Search.Instance))
            {
                panel_Student.Controls.Add(Teacher_Search.Instance);
                Teacher_Search.Instance.Dock = DockStyle.Fill;
                Teacher_Search.Instance.BringToFront();
            }
            else
                Teacher_Search.Instance.BringToFront();
        }

        private void Tab_View_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_View.Width;
            Line.Left = Tab_View.Left;

            if (!panel_Student.Controls.Contains(Teacher_View.Instance))
            {
                panel_Student.Controls.Add(Teacher_View.Instance);
                Teacher_View.Instance.Dock = DockStyle.Fill;
                Teacher_View.Search(); // Search method
                Teacher_View.Instance.BringToFront();
            }
            else
            {
                Teacher_View.Search(); // Search method
                Teacher_View.Instance.BringToFront();
            }
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            Line.Width = Tab_Register.Width;
            Line.Left = Tab_Register.Left;

            if (!panel_Student.Controls.Contains(Teacher_Register.Instance))
            {
                panel_Student.Controls.Add(Teacher_Register.Instance);
                Teacher_Register.Instance.Dock = DockStyle.Fill;
                Teacher_Register.Instance.BringToFront();
            }
            else
                Teacher_Register.Instance.BringToFront();
        }
    }
}
