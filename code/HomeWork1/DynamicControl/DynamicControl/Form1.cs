namespace DynamicControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int startPosition = 100;
            int endPosition = 10;
            for (int i = 0; i<=4; i++)
            {
                Label l = addLabel(i, startPosition, endPosition);
                this.Controls.Add(l);
                endPosition += 100;
            }
        }

        Label addLabel(int i, int start, int end) 
        {
            Label l = new Label();
            l.Name = "label" + i.ToString();
            l.Text = "label" + i.ToString();
            l.ForeColor = Color.White;
            l.BackColor = Color.Green;
            l.Font = new Font("Serif", 24, FontStyle.Bold);
            l.Width = 170;
            l.Height = 80;
            l.Location = new Point(start, end);
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding(5);

            return l;

        }
    }
}