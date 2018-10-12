using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_CG_14_1
{
    class Operators
    {
        /// <summary>
        /// adds 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>2 numbers added</returns>
        public static int Addition(int num1, int num2)
        {
            return (num1 + num2);
        }
        /// <summary>
        /// subtracting num2 from num1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num2 is subtracted from num1</returns>
        public static int Subtraction(int num1, int num2)
        {
            return (num1 - num2);
        }
        /// <summary>
        /// multiply 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 is multiplied by num2</returns>
        public static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }/// <summary>
         /// 2 numbers divided
         /// </summary>
         /// <param name="num1"></param>
         /// <param name="num2"></param>
         /// <returns>num1 divided by num2</returns>
        public static int Division(int num1, int num2)
        {
            return (num1 / num2);
        }
    }
}