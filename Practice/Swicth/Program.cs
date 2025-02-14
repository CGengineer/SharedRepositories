using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swicth
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = 1;

            switch (day)
            {
                case 1:
                    Console.WriteLine("月曜日");
                    break;
                case 2:
                    Console.WriteLine("火曜日");
                    break;
                case 3:
                    Console.WriteLine("水曜日");
                    break;
                case 4:
                    Console.WriteLine("木曜日");
                    break;
                case 5:
                    Console.WriteLine("金曜日");
                    break;
                case 6:
                    Console.WriteLine("土曜日");
                    break;
                case 7:
                    Console.WriteLine("日曜日");
                    break;
                default:
                    Console.WriteLine("無効な日");
                    break;
            }

            Console.ReadLine();
        }
    }
}
