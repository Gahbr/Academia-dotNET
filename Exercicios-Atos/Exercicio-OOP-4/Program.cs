namespace Exercicio_OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMotor motor;
            MotorEletrico motorEletrico = new MotorEletrico();
            MotorCombustao motorCombustao = new MotorCombustao();

            motorEletrico.Ligar();
            motorCombustao.Ligar();

        }
    }
}