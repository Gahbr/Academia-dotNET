
namespace Desafio_4_Estacionamento
{
    public partial class Form1 : Form
    {
        private List<Veiculo> listaVeiculos = new();
        private List<Veiculo> listaSaida = new();
        readonly static string entradaFilePath = "veiculosEntrada.dat";
        readonly static string saidaFilePath = "veiculosSaida.dat";
        readonly FileInfo fileInfo = new FileInfo(entradaFilePath);
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(entradaFilePath) && fileInfo.Length > 0)
            {
                StreamReader leitor = new StreamReader(entradaFilePath);
                do
                {
                    string linha = leitor.ReadLine();
                    string[] vetorDados = linha.Split(";");
                    Veiculo veiculo = new(vetorDados[0], DateTime.Parse(vetorDados[1]), DateTime.Parse(vetorDados[2]));

                    listaVeiculos.Add(veiculo);
                    listBoxVeiculosGaragem.Items.Add($"{veiculo.Placa}; {veiculo.DataEntrada:d}; {veiculo.HoraEntrada:t}");

                } while (!leitor.EndOfStream);

                leitor.Close();
            }

            if (File.Exists(saidaFilePath) && new FileInfo(entradaFilePath).Length > 0)
            {
                StreamReader leitor = new StreamReader(saidaFilePath);
                do
                {
                    string linha = leitor.ReadLine();
                    string[] vetorDados = linha.Split(";");
                    Veiculo veiculo = new(vetorDados[0], DateTime.Parse(vetorDados[1]), DateTime.Parse(vetorDados[2]));
                    string tempoFormatado = veiculo.TempoPermanencia.ToString(@"hh\:mm\:ss");
                    string dataEntradaFormatada = veiculo.DataEntrada.ToString(@"d");
                    string horaEntradaFormatada = veiculo.HoraEntrada.ToString(@"t");

                    listaVeiculos.Add(veiculo);
                    listBoxVeiculosSaida.Items.Add($"{veiculo.Placa};{dataEntradaFormatada};{horaEntradaFormatada};{tempoFormatado};{veiculo.ValorCobrado} {Environment.NewLine}");

                } while (!leitor.EndOfStream);

                leitor.Close();
            }
        }

        private void EntradaCarro(object sender, EventArgs e)
        {
            DateTime dataEntrada = DateTime.Today;
            DateTime horaEntrada = DateTime.Now;
            string placa = textBoxPlacaCarro.Text;

            Veiculo veiculo = new(placa, dataEntrada, horaEntrada);

            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Insira a placa do carro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Veiculo.TemLugar(listaVeiculos))
            {
                MessageBox.Show("Garagem atingiu a capacidade máxima (50)");
                return;
            }

            if (Veiculo.JaCadastrado(veiculo.Placa, listaVeiculos))
            {
                MessageBox.Show("Veículo ja cadastrado!!!!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            listaVeiculos.Add(veiculo);
            listBoxVeiculosGaragem.Items.Add($"{veiculo.Placa}; {veiculo.DataEntrada:d}; {veiculo.HoraEntrada:t}");

            //salvando no arquivo
            StreamWriter escritor = new StreamWriter(entradaFilePath, true);
            escritor.WriteLine($"{veiculo.Placa};{veiculo.DataEntrada:d};{veiculo.HoraEntrada:t}");
            escritor.Close();
        }

        private void SaidaCarro(object sender, EventArgs e)
        {
            string input = textBoxPlacaCarro.Text;
            Veiculo veiculo = Veiculo.EncontrarVeiculo(input, listaVeiculos);

            if (!Veiculo.JaCadastrado(input, listaVeiculos))
            {
                MessageBox.Show("Veículo não cadastrado no sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            veiculo.TempoPermanencia = DateTime.Now.Subtract(veiculo.HoraEntrada);
            veiculo.ValorCobrado = Math.Ceiling(veiculo.TempoPermanencia.TotalHours) * 5;

            string tempoFormatado = veiculo.TempoPermanencia.ToString(@"hh\:mm\:ss");
            string dataEntradaFormatada = veiculo.DataEntrada.ToString(@"d");
            string horaEntradaFormatada = veiculo.HoraEntrada.ToString(@"t");


            listBoxVeiculosSaida.Items.Add($"{veiculo.Placa};{dataEntradaFormatada};{horaEntradaFormatada};{tempoFormatado};{veiculo.ValorCobrado} {Environment.NewLine}");
            listaSaida.Add(veiculo);
            listaVeiculos.Remove(veiculo);
            textBoxTempoPermanencia.Text = tempoFormatado;
            textBoxValorPagar.Text = $"R${veiculo.ValorCobrado},00";

            //removendo da listbox
            for (int i = listBoxVeiculosGaragem.Items.Count - 1; i >= 0; i--)
            {
                string item = listBoxVeiculosGaragem.Items[i].ToString();

                if (item.Contains(veiculo.Placa))
                {
                    listBoxVeiculosGaragem.Items.RemoveAt(i);
                }
            }

            MessageBox.Show($"Placa: {veiculo.Placa} Tempo de permanência: {tempoFormatado} Valor a pagar: R${veiculo.ValorCobrado},00","Resultado", MessageBoxButtons.OK,MessageBoxIcon.Information);

            //salvando no arquivo VeiculosSaida
            StreamWriter escritor = new StreamWriter(saidaFilePath, true);
            escritor.WriteLine($"{veiculo.Placa};{dataEntradaFormatada};{horaEntradaFormatada};{tempoFormatado};{veiculo.ValorCobrado}");
            escritor.Close();


            //lendo o arquivo de entrada e atualizando
            StreamWriter atualizaArquivo = new StreamWriter(entradaFilePath, false);
            foreach (var item in listaVeiculos)
            {
                atualizaArquivo.WriteLine($"{item.Placa};{item.DataEntrada:d};{item.HoraEntrada:t}");
            }
            atualizaArquivo.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHoraAtual.Text = DateTime.Now.ToString("g");
        }
    }
}