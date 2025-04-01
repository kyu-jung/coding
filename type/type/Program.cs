using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type
{
    class Program
    {
        static void Main(string[] args)
        {
            // 실수 float 형 공부
            
            float pi = 3.14f;
            Console.WriteLine("PI:" + pi);

            // 실수 double 형 공부
            double radius = 2.5;
            Console.WriteLine("반지름:" + radius);

            //실수 decimal 형 공부
            decimal price = 20.01m;
            decimal quantity = 12;
            decimal total = price * quantity;
            Console.WriteLine("총가격:" + total);
            
                


        }
    }
}
