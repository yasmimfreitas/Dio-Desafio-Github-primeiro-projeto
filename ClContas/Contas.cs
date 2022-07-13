using System;
using System.Collections.Generic;
using System.Text;

namespace ClContas
{
    public class Contas
    {
        //public double num1;
        //double num2;

        
        private double num1;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        private double num2;

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public Contas()
        {
        }

        public Contas(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public string Somar()
        {
            return "A soma é " + (Num1 + Num2);
        }
        public string Somar(double num1, double num2)
        {
            return "A soma é " + (num1 + num2);
        }

        public string Subtrair()
        {
            return "A difereça é " + (Num1 - Num2);
        }

        public string Dividir()
        {
            return "A divisão é " + (Num1 / Num2);
        }
        public string Multiplicar()
        {
            return "O produto é " + (Num1 * Num2);
        }
    }
}
