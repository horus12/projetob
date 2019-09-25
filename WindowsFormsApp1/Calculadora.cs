using System;

namespace WindowsFormsApp1
{
    internal class Calculadora
    {
        public Calculadora()
        {
        }

        internal double calcula(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}