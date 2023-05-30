namespace Exercicio_Criptografia
{
    public partial class Form1 : Form
    {
        Assimetrica s = new Assimetrica();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string msg = textBoxMensagem.Text;
            string msgCripto = s.EncryptData(msg, "atos");
            labelCriptografada.Text = msgCripto;
        }

        private void buttonDescript_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string msg = labelCriptografada.Text;
            string msgDecrypt = s.DecryptData(msg, "atos");
            labelDescrypt.Text = msgDecrypt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamReader reader = new StreamReader("dadoscripto.txt");
            string line = reader.ReadLine();

            if (line != null)
            {
                Simetrica s = new Simetrica();
                string msg = line;
                string msgDecrypt = s.DecryptData(msg, "atos20232");
                labelDescrypt.Text = msgDecrypt;
                reader.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string msg = textBoxMensagem.Text;
            string msgCripto = s.encrypt(msg);
            labelCriptografada.Text = msgCripto;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string msg = labelCriptografada.Text;
            string msgDecrypt = s.decrypt(msg);
            labelDescrypt.Text = msgDecrypt;
        }
    }
}