using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsCalcApp
{

    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int? Divide(int x, int y)
        {
            try
            {
                return (x / y);
            }
            catch
            {
                Console.WriteLine("Attenzione non puoi dividere per zero!!!");
                return null;
            }
        }
        public int? Potenza(int b, int e)
        {

            if (e == 0)
            {
                return 1;
            }
            else if (e < 0)
            {
                throw new Exception("Errore: l'esponente deve essere non negativo.");
            }
            else
            {
                return b * Potenza(b, e - 1);
            }
        }
    }
}




    