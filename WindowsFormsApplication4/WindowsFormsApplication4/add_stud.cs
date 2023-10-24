using System;
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
    public partial class add_stud : Form
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        SqlDataReader dr; 
        String str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\WindowsFormsApplication4\WindowsFormsApplication4\Database1.mdf;
                        Integrated Security=True;User Instance=True";
        public add_stud()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(studname.Text != "" && em.Text != "" && fn.Text != "" && mn.Text != "" && dp.Text != "" )
            {
                try
                {
                    con = new SqlConnection(str);
                    String query = "insert into stud_info (regno,stud_name,email,f_name,m_name,dept) values ('" + studrg.Text + "','" + studname.Text + "','" + em.Text + "','" + fn.Text + "','" + mn.Text + "','" + dp.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        dr = cmd.ExecuteReader();
                        studrg.Text = "";
                        studname.Text = "";
                        em.Text = "";
                        fn.Text = "";
                        mn.Text = "";
                        dp.Text = "";
                        MessageBox.Show("okay");

                    }
                    catch (SqlException x)
                    {
                        MessageBox.Show(" " + x);
                    }
                }
                catch (SqlException x)
                {
                    MessageBox.Show("error" + x);
                }
            }
            else
            {
                MessageBox.Show("Input Values");
            }
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            this.Close();
            f1.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_adddept au = new Admin_adddept();
            this.Close();
            au.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_users au = new add_users();
            this.Close();
            au.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_staff ass = new add_staff();
            this.Close();
            ass.Show();
        }

        private void add_stud_Load(object sender, EventArgs e)
        {
            
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_sub sub = new add_sub();
            this.Close();
            sub.Show();
        }
    }
}
