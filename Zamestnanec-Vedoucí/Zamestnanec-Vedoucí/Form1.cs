using Microsoft.VisualBasic;

namespace Zamestnanec_Vedoucí
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vedouci Kuba;
        private void button1_Click(object sender, EventArgs e)
        {
        Kuba= new Vedouci(textBox1.Text,textBox2.Text,dateTimePicker1.Value,(int)numericUpDown1.Value,(int)numericUpDown2.Value,textBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}