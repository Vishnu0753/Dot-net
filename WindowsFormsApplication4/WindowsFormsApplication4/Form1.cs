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
    public partial class Form1 : Form
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        public string str;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            try
            {
                str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\WindowsFormsApplication4\WindowsFormsApplication4\Database2.mdf;
                        Integrated Security=True;User Instance=True";
                con = new SqlConnection();
                con.ConnectionString = str;
                con.Open();
                
            }
            catch (SqlException x)
            {
                label2.Text= " " + x;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            da = new SqlDataAdapter("select * from users where uname='" + uname.Text + "' and upass='" + upass.Text + "'", con);
            ds = new DataSet();
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][1].ToString() == uname.Text && dt.Rows[0][2].ToString() == upass.Text)
                {
                    uname.Text = "";
                    upass.Text = "";
                    if (dt.Rows[0][4].ToString() == "admin")
                    {
                        Form2 f1 = new Form2();
                        f1.Show();
                        this.Hide();
                    }
                    if (dt.Rows[0][4].ToString() == "student")
                    {
                        Form3 f = new Form3();
                        f.Show();
                        this.Hide();
                    }
                    if (dt.Rows[0][4].ToString() == "staff")
                    {
                        Form4 f2 = new Form4();
                        f2.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                label2.Text = "Username or Password is Wrong";
                uname.Text = "";
                upass.Text = "";
            }
            
        }

        
       
    }
}
