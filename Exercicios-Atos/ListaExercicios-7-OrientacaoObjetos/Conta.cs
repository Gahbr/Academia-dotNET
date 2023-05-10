//5 - Crie uma classe chamada Conta que tenha as propriedades Número, Saldo e Limite. Utilize o encapsulamento para 
//garantir que o saldo nunca seja menor que zero e que o limite seja positivo e que o Número da conta não possa
//ser alterado.

namespace Exercicio_1
{
    internal class Conta
    {
        private readonly int _numero;
        private decimal _saldo;
        private decimal _limite;

        public Conta(int numero, decimal saldo, decimal limite)
        {
            _numero = numero;
            _saldo = saldo > 0 ? saldo : 0; // garante que o saldo seja sempre maior ou igual a zero
            _limite = limite > 0 ? limite : 0; // garante que o limite seja sempre maior ou igual a zero
        }

        public int Numero
        {
            get { return _numero; }
        }

        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
                else
                {
                    throw new ArgumentException("O saldo não pode ser negativo.");
                }
            }
        }

        public decimal Limite
        {
            get { return _limite; }
            set
            {
                if (value >= 0)
                {
                    _limite = value;
                }
                else
                {
                    throw new ArgumentException("O limite não pode ser negativo.");
                }
            }
        }
    }

}
