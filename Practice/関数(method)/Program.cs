using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 関数_method_
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc();
        }

        // 2つの整数を受け取り、その合計を表示するmethod
        static void Calc()
        {
            var num1 = 1;
            var num2 = 2;
            var sumResult = num1 + num2;
            Console.WriteLine("5 + 10 = " + sumResult);
            Console.ReadLine();
        }

    }
}
