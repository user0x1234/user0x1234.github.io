namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            int forTimerInterval = rand.Next(10, 40);
            timer1.Interval = forTimerInterval;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int forButtonInterval = rand.Next(1, 4);
            button1.Location = new Point(button1.Location.X + forButtonInterval, button1.Location.Y - forButtonInterval);
        }
    

    private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}