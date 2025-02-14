using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 関数_引数と戻り値について_
{
    class Program
    {
        static void Main(string[] args)
        {
            // メソッドを呼び出して、結果を表示
            int sumResult = Add(5, 10); // 5と10を足す

            Console.WriteLine("5 + 10 = " + sumResult);

            Console.ReadLine();
        }

        // 2つの整数を受け取り、その合計を返すメソッド
        static int Add(int a, int b)
        {
            return a + b; // aとbの合計を返す
        }        
    }
}
