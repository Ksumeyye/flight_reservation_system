namespace Ucus_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: "+ comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text+ " Ad - Soyad: "+textBox1.Text+" Telefon No:  "+maskedTextBox2.Text+" TC:  "+maskedTextBox3.Text+ " ");
            MessageBox.Show("Yolcu Kayd� Ba�ar�yla Yap�lm��t�r.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}