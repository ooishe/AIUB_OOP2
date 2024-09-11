using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FS3OVK5Q\\WINCC;Initial Catalog=SampleDb;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into Table_1 values ( '" + int.Parse(textBox1.Text) + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "' , getdate(), getdate() )", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully recorded!");
                con.Close();
                reset();
                BindData();
            }

        }

        private bool isValid()
        {
            if (textBox1.Text == string.Empty ||
                textBox3.Text == string.Empty ||
                comboBox1.Text == string.Empty ||
                textBox4.Text == string.Empty)
            { 
                MessageBox.Show("Please Enter All Criteria", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Table_1", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Table_1 set Name = '" + textBox3.Text + "', Department = '"+comboBox1.Text+"', BookName='"+textBox4.Text+"', Updatedate= getdate() where ID ='"+ int.Parse(textBox1.Text) + "' ", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated!");
            con.Close();
            BindData();
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete Table_1 where ID='" + int.Parse(textBox1.Text) + "' ", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    BindData();
                    reset();
                    MessageBox.Show("Successfully Deleted!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Info");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Table_1 where ID='" + int.Parse(textBox1.Text) + "' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            textBox1.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox4.Clear();

            textBox1.Focus();
        }
    }
}
