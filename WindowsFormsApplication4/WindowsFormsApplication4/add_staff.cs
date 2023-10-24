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
    public partial class add_staff : Form
    {
        public add_staff()
        {
            InitializeComponent();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_adddept add = new Admin_adddept();
            this.Close();
            add.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_stud ast = new add_stud();
            this.Close();
            ast.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Close();
            f.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_users au = new add_users();
            this.Close();
            au.Show();
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_sub sub = new add_sub();
            this.Close();
            sub.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
