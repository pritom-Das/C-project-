using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        private SqlConnection Con = new SqlConnection(@"Data Source=PRITOM\SQLEXPRESS02;Initial Catalog=MyDB;Integrated Security=True;");
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from EmployeeTbl where EmpId ='" + EmpidTb.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Empidlbl.Text = dr["Empid"].ToString();
                empnamelbl.Text = dr["Empname"].ToString();
                empaddlbl.Text = dr["Empadd"].ToString();
                empgenderlbl.Text = dr["Empgender"].ToString();
                empposlbl.Text = dr["Emppos"].ToString();
                empdoblbl.Text = dr["Empdob"].ToString();
                empphonelbl.Text = dr["Empphone"].ToString();
                empedulbl.Text = dr["Empedu"].ToString();

                Empidlbl.Visible = true;
                empnamelbl.Visible = true;
                empaddlbl.Visible = true;
                empgenderlbl.Visible = true;
                empposlbl.Visible = true;
                empdoblbl.Visible = true;
                empphonelbl.Visible = true;
                empedulbl.Visible = true;


            }
            Con.Close();
        }
        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====EMPLOYEE SUMMARY=====", new Font("Century Gpthic",20, FontStyle.Bold), Brushes.Blue, new Point(175));
            e.Graphics.DrawString("Employee ID: " + Empidlbl.Text +"\tEmployee Name: "+empnamelbl.Text, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20,100));
            e.Graphics.DrawString("Employee Address: " + empaddlbl.Text + "\tEmployee Gender: " + empgenderlbl.Text, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 140));
            e.Graphics.DrawString("Employee Position: " + empposlbl.Text + "\tEmployee DOB: " + empdoblbl.Text, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 180));
            e.Graphics.DrawString("Employee Phone: " + empphonelbl.Text + "\tEmployee Education: " + empnamelbl.Text, new Font("Century Gpthic", 18, FontStyle.Bold), Brushes.Gray, new Point(20, 220));
            e.Graphics.DrawString("====EMPLOYEE SOFT=====", new Font("Century Gpthic", 20, FontStyle.Bold), Brushes.Blue, new Point(175,260));
        }

        
    }
}
