using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三項演算子
{
    class Program
    {
        static void Main(string[] args)
        {
            //条件 ? 真の場合の値 : 偽の場合の値
            var age = 20;
            var YesNo = (age >= 18) ? "はい" : "いいえ";
            Console.WriteLine(YesNo); // "はい" と表示される
            Console.ReadLine();
        }
    }
}
