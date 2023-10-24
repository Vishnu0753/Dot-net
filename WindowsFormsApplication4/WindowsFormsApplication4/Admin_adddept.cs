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
    public partial class Admin_adddept : Form
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        SqlDataReader dr;
        String str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\WindowsFormsApplication4\WindowsFormsApplication4\Database1.mdf;Integrated Security=True;User Instance=True";
        Form1 f = new Form1();
        public Admin_adddept()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                
                String query = "insert into depts (deptid,deptname) values ('" + did.Text + "','" + dn.Text + "');";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();    
                    MessageBox.Show("okay");
                    
                }
                catch (SqlException x)
                {
                    MessageBox.Show(" "+x);
                }
            }
            catch(SqlException x)
            {
                MessageBox.Show("error" + x);
            }
            
        }

        private void Admin_adddept_Load(object sender, EventArgs e)
        {

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

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_stud ast = new add_stud();
            this.Close();
            ast.Show();
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
    }
}
