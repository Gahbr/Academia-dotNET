//3 - Crie uma classe ContaCorrente que obedeça à descrição abaixo: A classe possui o atributo saldo do tipo 
//double e os métodos definirSaldoInicial, depositar e sacar. O método definirSaldoInicial deve atribuir o
//valor passado por parâmetro ao atribuito saldo O método depositar, deve adicionar o valor passado por
//parâmetro ao atributo saldo O método sacar deve reduzir o valor passado por parâmetro do saldo já 
//existente Necessário verificar a condição de o valor do saldo ser insuficiente para o saque que se deseja
//fazer. O valor de retorno deve ser true (verdadeiro) quando for possível realizar o saque e false (falso)
//quando não for possível
namespace Exercicio_1
{
    internal class ContaCorrente
    {
        private double saldo;
        public double Saldo { get => saldo; }

        public ContaCorrente()
        {
            saldo = 0;
        }

        public bool Sacar(double valorSaque)
        {
            if (valorSaque > saldo) return false;
            else
            {
                saldo -= valorSaque;
                return true;
            }
        }

        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void DefinirSaldoInicial(double valor)
        {
           if (valor > 0) saldo += valor;
        }
    }
}
