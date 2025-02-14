using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四則演算
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2つの整数を定義
            int num1 = 10;
            int num2 = 5;

            // 加算
            int sum = num1 + num2; // num1とnum2の和
            Console.WriteLine("加算: " + num1 + " + " + num2 + " = " + sum);

            // 減算
            int difference = num1 - num2; // num1からnum2を引いた差
            Console.WriteLine("減算: " + num1 + " - " + num2 + " = " + difference);

            // 乗算
            int product = num1 * num2; // num1とnum2の積
            Console.WriteLine("乗算: " + num1 + " * " + num2 + " = " + product);

            // 除算
            double quotient = (double)num1 / num2; // num1をnum2で割った商
            Console.WriteLine("除算: " + num1 + " / " + num2 + " = " + quotient);

            // 剰余
            int remainder = num1 % num2; // num1をnum2で割った余り
            Console.WriteLine("剰余: " + num1 + " % " + num2 + " = " + remainder);

            Console.ReadLine();
        }
    }
}
