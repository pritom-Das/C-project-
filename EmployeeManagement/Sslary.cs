using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Numerics;

namespace EmployeeManagement
{
    public partial class Sslary : Form
    {
        public Sslary()
        {
            InitializeComponent();
        }
        private SqlConnection Con = new SqlConnection(@"Data Source=PRITOM\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True;");
        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void fetchempdata()
        {
            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter Employee Id");
            }
            else
            {
                Con.Open();
                string query = "select * from EmployeeTbl where EmpId ='" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    // EmpIdTb.Text = dr["Empid"].ToString()
                    EmpNameTb.Text = dr["Empname"].ToString();
                    EmpPosTb.Text = dr["EmpPos"].ToString();

                }
                Con.Close();
            }
        }

        private void Sslary_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        int Dailybase, total;
        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpPosTb.Text == "")
            {
                MessageBox.Show("Select An Employee");
            }
            else if (WorkedTb.Text == "" || Convert.ToInt32(WorkedTb.Text) > 28)
            {
                MessageBox.Show("Enter A Valid Number Of Days");
            }
            else
            {
                if (EmpPosTb.Text == "Manager")
                {
                    Dailybase = 250;
                }
                else if (EmpPosTb.Text == "Senior Developer")
                {
                    Dailybase = 200;
                }
                else
                {
                    Dailybase = 150;
                }
                total = Dailybase * Convert.ToInt32(WorkedTb.Text);
                SalarySlip.Text = "Employee Id :" + EmpIdTb.Text + "\n" + "Employee Name :" + EmpNameTb.Text + "\n" + "Employee Position :" + EmpPosTb.Text + "\n" + "Days Worked :" + WorkedTb.Text + "\n" + "Daily Salary :" + Dailybase + "\n" + "Total  Salary :" + total;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====Salary Document=====", new Font("Century Gpthic", 20, FontStyle.Bold), Brushes.Blue, new Point(175));
            e.Graphics.DrawString("Employee ID: " + EmpIdTb.Text, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 100));
            // e.Graphics.DrawString("Employee Address: ", new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 140));
            e.Graphics.DrawString("Employee Position: " + EmpPosTb.Text, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 140));
            e.Graphics.DrawString("Work Days: " + WorkedTb.Text, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 180));
            e.Graphics.DrawString("Daily Salary: " + Dailybase, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 220));
            e.Graphics.DrawString("Total Salary: " + total, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 260));
            e.Graphics.DrawString("====EMPLOYEE SOFT=====", new Font("Century Gpthic", 20, FontStyle.Bold), Brushes.Blue, new Point(175, 300));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
