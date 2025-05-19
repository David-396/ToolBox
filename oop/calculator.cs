using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class calculator
    {
        public int num1 ;
        public int num2;
        public int num3;

        public calculator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public calculator(int num2)
        {
            this.num2 = num2;
        }

        public void print()
        {
            Console.WriteLine(this.num1);
        }

        public void times()
        {
            Console.WriteLine(this.num1 * this.num2);
        }

        public void plus()
        {
            Console.WriteLine(this.num1 + this.num2);
        }

        public void minus()
        {
            Console.WriteLine(this.num1 - this.num2);
        }

        public void divide()
        {
            Console.WriteLine(this.num1 / this.num2);
        }
    }
}
