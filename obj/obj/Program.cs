using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj1 = 123;
            object obj2 = "이건 오브젝트 자료형 입니다.";
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int a = 123456;
            string b = "123456";
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine($"object1 : {obj1}, object2 : {obj2}");
            Console.WriteLine("object1 : " + obj1 + "object2 : " + obj2);

            //암시적 형 변환
            int c = 123;
            double d;
            d = c;

            //명시적 변환 (문자에서 숫자로 변환)
            
            int f = Convert.ToInt32(b);
            Console.WriteLine(f);

            string pi = "3.14";
            double pi2 = double.Parse(pi);
            Console.WriteLine(pi2);


            //명시적 변환(큰 자료형에서 작은 자료형)
            double coffee = 123.456;
            int cup = (int)coffee;

            Console.WriteLine(cup);


        }
    }
}
