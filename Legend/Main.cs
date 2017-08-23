using Legend.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.CenterToScreen(); // Centers the form on the screen.
        }

        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        private void Btn_Student_Click(object sender, EventArgs e)
        {
            if (!panel_Body.Controls.Contains(Student.Instance))
            {
                panel_Body.Controls.Add(Student.Instance);
                Student.Instance.Dock = DockStyle.Fill;
                Student.Instance.BringToFront();
            }
            else
                Student.Instance.BringToFront();
        }

        private void Close_Window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Window_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!panel_Body.Controls.Contains(Student.Instance))
            {
                panel_Body.Controls.Add(Student.Instance);
                Student.Instance.Dock = DockStyle.Fill;
                Student.Instance.BringToFront();
            }
            else
                Student.Instance.BringToFront();
        }

        private void Btn_Class_Click(object sender, EventArgs e)
        {
            if (!panel_Body.Controls.Contains(Class.Instance))
            {
                panel_Body.Controls.Add(Class.Instance);
                Class.Instance.Dock = DockStyle.Fill;
                Class.Instance.BringToFront();
            }
            else
                Class.Instance.BringToFront();
        }

        private void Btn_Teacher_Click(object sender, EventArgs e)
        {
            if (!panel_Body.Controls.Contains(Teacher.Instance))
            {
                panel_Body.Controls.Add(Teacher.Instance);
                Teacher.Instance.Dock = DockStyle.Fill;
                Teacher.Instance.BringToFront();
            }
            else
                Teacher.Instance.BringToFront();
        }
    }
}
