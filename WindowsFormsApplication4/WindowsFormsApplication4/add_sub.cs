﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class add_sub : Form
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        SqlDataReader dr;
        String str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\WindowsFormsApplication4\WindowsFormsApplication4\Database1.mdf;Integrated Security=True;User Instance=True";
        public add_sub()
        {
            InitializeComponent();
        }

        private void addDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_adddept au = new Admin_adddept();
            this.Close();
            au.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_stud asd = new add_stud();
            this.Close();
            asd.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_staff ass = new add_staff();
            this.Close();
            ass.Show();
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_users au = new add_users();
            this.Close();
            au.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                String query = "insert into sub_info (sub_id,dept,subject) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("okay");

                }
                catch (SqlException x)
                {
                    MessageBox.Show("error" + x);
                }
            }
                catch (SqlException x)
                {
                    MessageBox.Show("error" + x);
                }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 au = new Form2();
            this.Close();
            au.Show();
        }
    }
}
