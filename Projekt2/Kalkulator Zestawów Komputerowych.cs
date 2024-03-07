namespace Projekt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            komputer nowe_okno = new
            komputer(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
