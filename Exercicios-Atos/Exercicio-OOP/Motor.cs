using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OOP
{
    internal class Motor
    {
        private int cilindradas;
        private bool ligado;

        public int Cilindradas 
        { 
            get { return cilindradas; } 
            set {  cilindradas = value; } 
        }
        public bool Ligado
        {
            get { return ligado; }
        }

        public void LigarMotor()
        {
            ligado = true;
        }
        public void DesligarMotor()
        {
            ligado = false;
        }
    }
}
