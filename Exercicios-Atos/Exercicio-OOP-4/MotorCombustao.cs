using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OOP_4
{
    internal class MotorCombustao : IMotor
    {
        public double gasolina;
        public bool ligado;

        public void Desligar()
        {
            if (ligado) ligado = false;
            Console.WriteLine("Desligando o motor a combustao");
        }

        public void Ligar()
        {
            if (gasolina > 0 && !ligado) ligado = true;
            Console.WriteLine("Ligando o motor à combustao");
        }
    }
}
