using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_foreach_while
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("for:");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("数値: " + i);
            }

            List<string> fruitList = new List<string> { "りんご", "バナナ", "オレンジ" };
            // foreach文の例
            Console.WriteLine("foreach文の出力:");
            foreach (string fruit in fruitList)
            {
                Console.WriteLine("果物: " + fruit);
            }

            // while文の例
            int count = 1;
            Console.WriteLine("while文の出力:");
            while (count <= 5)
            {
                Console.WriteLine("カウント: " + count);
                count++; // カウントを増やす
            }

            Console.ReadLine();
        }
    }
}
