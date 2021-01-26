using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maths
{
    internal class FourOperations
    {
        public int Addition(int numb1, int numb2)
        {
            return numb1 + numb2;
        }

        /// <summary>
        /// Overload 
        /// </summary>
        /// <param name="numbs"></param>
        /// <returns></returns>
        public int Addition(params int[] numbs)
        {
            return numbs.Sum();
        }

        public int Subtraction(int numb1, int numb2)
        {
            return numb1 - numb2;
        }
        public double Multiplication(int numb1, int numb2)
        {
            return numb1 * numb2;
        }

        public double Multiplication(params int[] numbs)
        {
            double result = 1;
            for (int i = 0; i < numbs.Length - 1; i++)
            {
                result *= numbs[i];
            }
            return result;
        }

        public int Division(int numb1, int numb2)
        {
            return numb1 / numb2;
        }
    }
}
