using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_object
{
    class Program
    {
        static void Main(string[] args)
        {
            // object 자료형
            object 아빠 = 1234;
            Console.WriteLine(아빠);
            Console.WriteLine(아빠.GetType());


            아빠 = "문자";
            Console.WriteLine(아빠);
            Console.WriteLine(아빠.GetType());


            object 엄마 = "엄마, 아빠 보고싶어요";
            Console.WriteLine(엄마);
            Console.WriteLine(엄마.GetType());

            // dynamic 자료형 예제
            dynamic 할아버지 = 1234;
            Console.WriteLine(할아버지);
            Console.WriteLine(할아버지.GetType());

            할아버지 = "문자열";
            Console.WriteLine(할아버지);
            Console.WriteLine(할아버지.GetType());

            dynamic 할머니 = "할아버지, 할머니 보고싶어";
            Console.WriteLine(할머니);
            Console.WriteLine(할머니.GetType());

        }
    }
}
