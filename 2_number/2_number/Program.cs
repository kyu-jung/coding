using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // 실수형 예제
            // float 자료형 예제
            float 소수점 = 3.14f;
            Console.WriteLine("소수점 : " + 소수점);

            //float 자료형을 사용하고 "리모콘" 변수에 1.23을 넣고 출력해보자.
            float 리모콘 = 1.23f;
            Console.WriteLine(리모콘);

            //double 자료형 예제
            double 원 = 5.5;
            Console.WriteLine("원 : " + 원);

            //double 자료형을 사용하고 "코딩" 변수에 0.0001을 넣고 출력하자.
            double 코딩 = 0.0001;
            Console.WriteLine(코딩);

            // decimal 자료형 예제
            decimal 가격 = 20.03m;
            Console.WriteLine("가격 : " + 가격);

            // decimal 자료형을 사용하고 "커피" 변수에 99.99를 넣고 출력하자.
            decimal 커피 = 99.99m;
            Console.WriteLine(커피);

        }
    }
}
