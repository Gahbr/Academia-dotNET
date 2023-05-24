using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Desafio_4_Estacionamento
{
    public partial class Form1 : Form
    {
        private List<Veiculo> listaVeiculos = new();
        private List<Veiculo> listaSaida = new();
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Veículo ja cadastrado!!!!!");
                return;
            }

            listaVeiculos.Add(veiculo);
            listBoxVeiculosGaragem.Items.Add($"{veiculo.Placa}; {veiculo.DataEntrada:d}; {veiculo.HoraEntrada:t}");
        }

        private void SaidaCarro(object sender, EventArgs e)
        {
            string input = textBoxPlacaCarro.Text;
            Veiculo veiculo = Veiculo.EncontrarVeiculo(input, listaVeiculos);
            string placa = veiculo.Placa;
            if (!Veiculo.JaCadastrado(placa, listaVeiculos))
            {
                MessageBox.Show("Veículo não cadastrado no sistema!");
                return;
            }

            veiculo.TempoPermanencia = DateTime.Now.Subtract(veiculo.HoraEntrada);
            veiculo.ValorCobrado = Math.Ceiling(veiculo.TempoPermanencia.TotalHours) * 5;

            string tempoFormatado = veiculo.TempoPermanencia.ToString(@"hh\:mm\:ss");
            string dataEntradaFormatada = veiculo.DataEntrada.ToString(@"d");
            string horaEntradaFormatada = veiculo.HoraEntrada.ToString(@"t");


            textBoxVeiculosSaida.AppendText($"{veiculo.Placa};{dataEntradaFormatada};{horaEntradaFormatada};{tempoFormatado};{veiculo.ValorCobrado} {Environment.NewLine}");

            listaSaida.Add(veiculo);
            listaVeiculos.Remove(veiculo);

            for (int i = listBoxVeiculosGaragem.Items.Count - 1; i >= 0; i--)
            {
                string item = listBoxVeiculosGaragem.Items[i].ToString();

                if (item.Contains(veiculo.Placa))
                {
                    listBoxVeiculosGaragem.Items.RemoveAt(i);
                }
            }

            MessageBox.Show($"Placa: {veiculo.Placa} Tempo de permanência: {tempoFormatado} Valor a pagar: R${veiculo.ValorCobrado}");


            //         2) Veículos que saíram da garagem: TextBox(multiplas linhas) + List < Veiculos > +arquivo(veiculosSaida.dat)
            //O conteúdo do arquivo veiculosSaida.dat deve conter os dados organizados:
            //         placa; dataEntrada; horaEntrada; tempoPermanecia; valorCobrado
            //         Por exemplo, placa; 62 minutos ou 2 horas; 10 reais
            //         IPL7154; 11 / 06 / 2022; 12:34; 62; 10
        }
    }
}