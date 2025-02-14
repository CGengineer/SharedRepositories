using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 配列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers_pattern_1 = new int[5]; // サイズ5の整数型配列を宣言
            numbers_pattern_1[0] = 1; // 配列の要素に値を代入
            numbers_pattern_1[1] = 2;
            numbers_pattern_1[2] = 3;
            numbers_pattern_1[3] = 4;
            numbers_pattern_1[4] = 5;

            // numbers_pattern_1の出力
            Console.WriteLine("numbers_pattern_1:");
            for (int i = 0; i < numbers_pattern_1.Length; i++)
            {
                Console.WriteLine(numbers_pattern_1[i]);
            }

            int[] numbers_pattern_2 = new int[] { 1, 2, 3, 4, 5 };

            // numbers_pattern_2の出力
            Console.WriteLine("numbers_pattern_2:");
            for (int i = 0; i < numbers_pattern_2.Length; i++)
            {
                Console.WriteLine(numbers_pattern_2[i]);
            }


            Console.ReadLine();
        }
    }
}
