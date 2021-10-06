using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.ClassOperations
{
    public class MyOperations
    {
        //add operation
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        //subtract operation
        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        //multiply operation
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        //division operation
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }

        //modulus operation
        public int Modulus(int value1, int value2)
        {
            return value1 % value2;
        }
    }
}
