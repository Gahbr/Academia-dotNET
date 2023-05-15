using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OOP_4
{
    internal class MotorEletrico : IMotor
    {
        public double correnteEletrica;
        public bool ligado;
        
        public void Desligar()
        {
            if(ligado) ligado = false;
            Console.WriteLine("Desligando o motor elétrico");
        }

        public void Ligar()
        {
            if (correnteEletrica > 0 && !ligado) ligado = true;
            Console.WriteLine("Ligando o motor elétrico");
        }
    }
}
