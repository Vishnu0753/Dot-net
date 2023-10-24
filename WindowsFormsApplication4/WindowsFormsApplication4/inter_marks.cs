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
    public partial class inter_marks : Form
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        String str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\WindowsFormsApplication4\WindowsFormsApplication4\Database1.mdf;Integrated Security=True;User Instance=True";
        public inter_marks()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "")
            {
                try
                {
                    con = new SqlConnection(str);
                    String q = "select subject,sub_id from sub_info where dept='" + comboBox1.SelectedItem + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        label3.Text = (ds.Tables[0].Rows[0][0].ToString());
                        label4.Text = (ds.Tables[0].Rows[1][0].ToString());
                        label5.Text = (ds.Tables[0].Rows[2][0].ToString());
                        label6.Text = (ds.Tables[0].Rows[3][0].ToString());
                        label7.Text = (ds.Tables[0].Rows[0][1].ToString());
                        label8.Text = (ds.Tables[0].Rows[1][1].ToString());
                        label9.Text = (ds.Tables[0].Rows[2][1].ToString());
                        label10.Text = (ds.Tables[0].Rows[3][1].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No subjects found");
                    }
                }
                catch(SqlException x)
                {
                    MessageBox.Show("" + x);
                }
            }
        }

        private void inter_marks_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                String q = "select deptname from depts ";
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            catch (SqlException x)
            {
                MessageBox.Show("" + x);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                try
                {
                    con = new SqlConnection(str);
                    String q = "insert into inter_marks(subject_name,marks_,stud_name) values ('" + label3.Text + "','" + textBox1.Text + "','" + textBox5.Text + "'),('" + label4.Text + "','" + textBox2.Text + "','" + textBox5.Text + "'),('" + label5.Text + "','" + textBox3.Text + "','" + textBox5.Text + "'),('" + label6.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Values inserted");
                    }
                    catch (SqlException x)
                    {
                        MessageBox.Show("error in insert" + x);
                    }
                                       
                }
                catch (SqlException x)
                {
                    MessageBox.Show("error in connection" + x);
                }
            }
            else
            {
                MessageBox.Show("Input Values");
            }
        }
    }
}
