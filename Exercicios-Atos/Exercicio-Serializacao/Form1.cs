using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Exercicio_Serializacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serializar = textBox1.Text;
            FileStream fs = new FileStream("Ricardo.data", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, serializar);
            fs.Close();
            MessageBox.Show("Serializado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("Ricardo.data", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string msgDesserializada = (string)bf.Deserialize(fs);

            MessageBox.Show("Mensagem Desserializada com sucesso!");

            label1.Text = msgDesserializada;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNome.Text;
            p.idade = int.Parse(txbIdade.Text);
            p.salario = double.Parse(txbSalario.Text);

            FileStream fs = new FileStream("pessoal.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            xml.Serialize(fs, p);

            MessageBox.Show("Serializado em XML");
        }

        private void buttonDess_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            StreamReader reader = new StreamReader("pessoal.xml");
            Pessoa pDes;
            pDes = (Pessoa)xml.Deserialize(reader);
            labelNome.Text = pDes.nome;
            labelIdade.Text = pDes.idade.ToString();
            labelSalario.Text = pDes.salario.ToString();
            reader.Close();
        }

        private void buttonSJSON_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBox2.Text;
            p.idade = int.Parse(textBox4.Text);
            p.salario = double.Parse(textBox3.Text);

            JsonSerializer serializer = new();
            StreamWriter sw = new StreamWriter("pessoas.json");
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, p);
            sw.Close();
            writer.Close();
        }
        private void buttonDJSON_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("pessoas.json");
            Pessoa pDes = JsonConvert.DeserializeObject<Pessoa>(json);
            label6.Text = pDes.nome;
            label7.Text = pDes.idade.ToString();
            label8.Text = pDes.salario.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }


    }
}