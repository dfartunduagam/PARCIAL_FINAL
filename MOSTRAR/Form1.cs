namespace MOSTRAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox1.Location.X, pictureBox4.Location.Y + 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox1.Location.X - 1, pictureBox4.Location.Y);
        }
    }
}
