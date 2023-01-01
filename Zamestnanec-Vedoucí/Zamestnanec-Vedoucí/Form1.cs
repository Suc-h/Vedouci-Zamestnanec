using Microsoft.VisualBasic;

namespace Zamestnanec_Vedoucí
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool vedouci = true;
        Vedouci Kuba;
        Zamestnanec Ondra;
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                Kuba = new Vedouci(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value, (int)numericUpDown2.Value, textBox3.Text);
                vedouci=true;
                label8.Text =Kuba.ToString();
            }
            else
            {
                Ondra = new Zamestnanec(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value);
                vedouci = false;
                label9.Text = Ondra.ToString();
            }
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vedouci)
            {

                Kuba.OdpracujHodiny((int)numericUpDown3.Value);
                label8.Text = Kuba.ToString();
            }
            else
            {
                Ondra.OdpracujHodiny((int)numericUpDown3.Value);
                label9.Text = Ondra.ToString();
            }
            
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vedouci)
            {

                MessageBox.Show("Vedoucí je ve firmě: " + Kuba.PocetDni());
            }
            else
            {
                MessageBox.Show("Zaměstnanec je ve firmě: " + Ondra.PocetDni());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (vedouci)
            {

                MessageBox.Show("Vedoucí si vydělal: " + Kuba.VypoctiMzdu());
                label8.Text = Kuba.ToString();
            }
            else
            {
                MessageBox.Show("Zaměstnanec si vydělal: " + Ondra.VypoctiMzdu());
                label9.Text = Ondra.ToString();
            }
        }
    }
}