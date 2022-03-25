namespace HolaMundo
{
    public partial class Form1 : Form
    {
        double total;


        public Form1()
        {
            InitializeComponent();
            total = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            var r = Double.TryParse(text.Text.Trim(), out double temporal);
            if (r)
            {
                text.Text = "";
                total += temporal;
            }
            else
            {
                MessageBox.Show("debe ser un valor numerico");
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            resultado.AppendText(total.ToString());
        }
    }
}