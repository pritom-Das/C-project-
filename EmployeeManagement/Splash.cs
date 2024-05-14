namespace EmployeeManagement
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int strtpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            strtpoint += 1;
            MyProgress.Value = strtpoint;
            if (MyProgress.Value == 50)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
