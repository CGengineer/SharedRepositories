using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =10;

            // if文の例
            if (number == 0)// numberが0より大きい場合の処理
            {
                Console.WriteLine("ifを通りました");
            }
            else if (number == 10)//numberが0より大きい場合と0以下の場合の処理
            {
                Console.WriteLine("else if を通りました");
            }
            else
            {
                Console.WriteLine("elseを通りました");
            }


            Console.ReadLine();
        }
    }
}
