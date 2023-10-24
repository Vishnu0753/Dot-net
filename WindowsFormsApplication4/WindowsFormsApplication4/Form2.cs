using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {        
        public Form2()
        {
            InitializeComponent();
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_users au = new add_users();
            this.Close();
            au.Show();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void addDeptToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Admin_adddept au = new Admin_adddept();
            this.Close();
            au.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_staff ass = new add_staff();
            this.Close();
            ass.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_stud asd = new add_stud();
            this.Close();
            asd.Show();
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_sub sub = new add_sub();
            this.Close();
            sub.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
