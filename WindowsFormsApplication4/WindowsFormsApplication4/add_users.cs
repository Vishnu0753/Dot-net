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
    public partial class add_users : Form
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        SqlDataReader dr;
        String str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\WindowsFormsApplication4\WindowsFormsApplication4\Database1.mdf;Integrated Security=True;User Instance=True";
        public add_users()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" )
            {
                try
                {
                    con = new SqlConnection(str);
                    String query = "insert into users (uid,uname,upass,name,utype) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("okay");
                }
                catch (SqlException x)
                {
                    MessageBox.Show("error" + x);
                }
            }
            else
            {
                MessageBox.Show("input values");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Close();
            f.Show();
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
            add_sub sub = new add_sub();
            this.Close();
            sub.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    con = new SqlConnection(str);
                    String query = "select * from users where uname='" + textBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        try
                        {
                            con = new SqlConnection(str);
                            String query1 = "update users set upass='" + textBox3.Text + "' where uname='" + textBox2.Text + "'";
                            SqlCommand cmd2 = new SqlCommand(query1, con);
                            con.Open();
                            dr = cmd2.ExecuteReader();
                            MessageBox.Show("Password updated");
                        }
                        catch (SqlException x)
                        {
                            MessageBox.Show("error in update" + x);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No user found");
                    }
                }
                catch(SqlException x)
                {
                    MessageBox.Show(" error in select" + x);
                }
                
            }
            else
            {
                MessageBox.Show("input values");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con = new SqlConnection(str);
                String query = "select * from users where uname='" + textBox2.Text + "'";
                SqlCommand cmd2 = new SqlCommand(query, con);
                con.Open();
                dr = cmd2.ExecuteReader();
                if (dr.HasRows)
                {
                    try
                    {
                        String query1 = "delete from users where uname='" + textBox2.Text + "'";
                        SqlCommand cmd = new SqlCommand(query1, con);
                        con.Open();
                        dr = cmd.ExecuteReader();
                        MessageBox.Show("okay");
                    }
                    catch (SqlException x)
                    {
                        MessageBox.Show("error in delete" + x);
                    }
                }
                else
                {
                    MessageBox.Show("No user found");
                }
            }
            else
            {
                MessageBox.Show("input values");
            }
            
        }

        private void add_users_Load(object sender, EventArgs e)
        {

        }
    }
}
 