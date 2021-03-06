﻿using System;
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
    public partial class Student : UserControl
    {
        private static Student _instance;

        public static Student Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Student();

                return _instance;
            }
        }


        public Student()
        {
            InitializeComponent();
        }

        private void Tab_Register_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_Register.Width;
            Line.Left = Tab_Register.Left;

            if (!panel_Student.Controls.Contains(Student_Register.Instance))
            {
                panel_Student.Controls.Add(Student_Register.Instance);
                Student_Register.Instance.Dock = DockStyle.Fill;
                Student_Register.Instance.BringToFront();
            }
            else
                Student_Register.Instance.BringToFront();
        }

        private void Tab_Search_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_Search.Width;
            Line.Left = Tab_Search.Left;

            if (!panel_Student.Controls.Contains(Student_Search.Instance))
            {
                panel_Student.Controls.Add(Student_Search.Instance);
                Student_Search.Instance.Dock = DockStyle.Fill;
                Student_Search.Instance.BringToFront();
            }
            else
                Student_Search.Instance.BringToFront();
        }

        private void Tab_View_Click(object sender, EventArgs e)
        {
            Line.Width = Tab_View.Width;
            Line.Left = Tab_View.Left;

            if (!panel_Student.Controls.Contains(Student_View.Instance))
            {
                panel_Student.Controls.Add(Student_View.Instance);
                Student_View.Instance.Dock = DockStyle.Fill;
                Student_View.Search(); // Search method
                Student_View.Instance.BringToFront();
            }
            else
            {
                Student_View.Search(); // Search method
                Student_View.Instance.BringToFront();
            }
                
        }

        private void Student_Load(object sender, EventArgs e)
        {
            Line.Width = Tab_Register.Width;
            Line.Left = Tab_Register.Left;

            if (!panel_Student.Controls.Contains(Student_Register.Instance))
            {
                panel_Student.Controls.Add(Student_Register.Instance);
                Student_Register.Instance.Dock = DockStyle.Fill;
                Student_Register.Instance.BringToFront();
            }
            else
                Student_Register.Instance.BringToFront();
        }
    }
}
