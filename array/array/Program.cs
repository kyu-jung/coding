using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열 선언 및 초기화
            int[] number = new int[5]; // {0, 0, 0, 0, 0}

            int[] num = { 1, 2, 3, 4, 5 };

            //요소 한줄씩 출력하기
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);
            Console.WriteLine(num[3]);
            Console.WriteLine(num[4]);

            //요소 for문으로 출력하기(조건을 확실하게 조절하줘야함)
            for (int i = 0; i < num.Length; i++)
            {
               Console.WriteLine(num[i]);
            }

            //요소 foreach로 출력하기(배력이 끝나면 알아서 끝남)
            foreach (var item in num)
            {
                Console.WriteLine(item);

            }
        }
    }
}
