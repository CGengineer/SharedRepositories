using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace リスト
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listの宣言と初期化
            List<int> numbers_list_1 = new List<int>(); // 空のリストを作成
            numbers_list_1.Add(1); // 要素を追加
            numbers_list_1.Add(2);
            numbers_list_1.Add(3);
            numbers_list_1.Add(4);
            numbers_list_1.Add(5);

            List<int> numbers_list_2 = new List<int> { 1, 2, 3, 4, 5 }; // 初期化子を使ってリストを作成

            // numbers_list_1の出力
            Console.WriteLine("numbers_list_1:");
            foreach (int number in numbers_list_1)
            {
                Console.WriteLine(number);
            }

            // numbers_list_2の出力
            Console.WriteLine("numbers_list_2:");
            foreach (int number in numbers_list_2)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
