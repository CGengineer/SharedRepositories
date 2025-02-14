using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数型の変数を定義
            int age = 25; // 年齢を格納する変数
            Console.WriteLine("年齢: " + age);

            // 浮動小数点型の変数を定義
            double height = 1.75; // 身長をメートル単位で格納する変数
            Console.WriteLine("身長: " + height + " m");

            // 文字列型の変数を定義
            string name = "太郎"; // 名前を格納する変数
            Console.WriteLine("名前: " + name);

            // ブール型の変数を定義
            bool isStudent = true; // 学生かどうかを示す変数
            Console.WriteLine("学生かどうか: " + isStudent);

            Console.ReadLine();
        }
    }
}
