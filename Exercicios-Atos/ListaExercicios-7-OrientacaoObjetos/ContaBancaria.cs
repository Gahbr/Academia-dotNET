//9 - Crie uma classe chamada ContaBancaria que tenha as propriedades NumeroConta, Titular, Saldo e Limite. Crie também
//um método chamado Depositar, que recebe um valor e adiciona ao saldo da conta, e um método Sacar, que recebe um 
//valor e verifica se o saldo é suficiente para a operação.
namespace Exercicio_1
{
    internal class ContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        private double _saldo;

        private double _limite;

        public int NumeroConta { get => _numeroConta; set => _numeroConta = value; }
        public string Titular
        {
            get { return _titular; }
            set 
            { if (!String.IsNullOrEmpty(value)){
                    _titular = value.ToUpper();
            } }
        }
        
        public double Saldo
        {
            get
            {
                return _saldo;
            }
        }

        public double Limite
        {
            get
            {
                return _limite;
            }
            set
            {
                if (value > 0)
                {
                    _limite = value;
                }
            }
        }

        //construtor
        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            this._saldo = saldo;

        }

        // metodos
        public void Depositar(double valDeposito)
        {
            if (valDeposito > 0)
            {
                _saldo += valDeposito;
            }else
            {
                Console.WriteLine("Depósito não efetuado");
            }
        }

        public void Sacar (double valSaque)
        {
            if (valSaque <= (_saldo+Limite)) _saldo -=valSaque;
            else Console.WriteLine("Saque não efetuado!");
        }
      
    }
}
