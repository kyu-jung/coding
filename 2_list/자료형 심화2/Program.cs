using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 자료형_심화2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 전용 리스트
            List<String> list = new List<String>();


            // 모든 자료형용 리스트
            List<object> list2 = new List<object>();

            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add('a');
            list2.Add('b');
            list2.Add('c');


            // 선언과 초기화
            List<object> list3 = new List<object>
            {"a", "b", "c", 1, 2, 3};

            List<dynamic> list4 = new List<dynamic>
            {"a", "b", "c", 1, 2, 3};

            Console.WriteLine(list3[0]);
            Console.WriteLine(list3.GetType());
            Console.WriteLine(list4[0]);
            Console.WriteLine(list4.GetType());


            // 이중 리스트
            List<object> list5 = new List<object>
            {"a", "b", "c", 1, 2, 3,
                new List<object> {"e", "f", "g", 4, 5, 6 }
            };
            // object 리스트 안에 object 리스트에서 출력값을 가져오려면
            // 리스트안의 리스트 자체가 object이기 때문에
            // 큰형태의 자료형인 object를 list에 넣으려고 함으로
            // list로 형변환을 한 후 출력할 수 있다.



            // 1. object 리스트 선언
            // 2. dynamic 형으로 리스트 선언과 초기화
            // 3. 이중 리스트 자료형은 자유
            List<object> list6 = new List<object>();

            List<dynamic> list7 = new List<dynamic> 
            { "한국",10, 20, 30, 40, "미국", "유럽"};

            List<dynamic> list8 = new List<dynamic> 
            {123, 456, 234, 
                new List<dynamic> {987, 876, "대전", "아산" } 
            };

            Console.WriteLine(list7[0]);
            Console.WriteLine(list8[3][0]);

            Console.WriteLine();
            Console.WriteLine();
            // 바깥 리스트 List<object>
            // 안쪽 리스트 List<int>
            List<object> outlist = new List<object>
            { 1, 2, 3, "C#","파이썬",
                new List<int> { 10, 20, 30, 40, 50, 60 }
            };

            Console.WriteLine(outlist[0]);
            Console.WriteLine(outlist[5]);

            Console.WriteLine();
            // 명시적 형변환
            List<int> inlist = (List<int>)outlist[5]; // { 10, 20, 30, 40, 50, 60 }

            Console.WriteLine(inlist[0]);


            // 1. object 바깥 리스트 만들고
            // 2. string list 만들고 리스트 안의 값에 접근하기

            List<object> outlist2 = new List<object>
            { "a", "b", "c", 1,2,3,
                new List<string> { "f", "g", "h"}
            };

            // 이중리스트로 만들어진 내부 리스트를 가져오는 과정
            // 내부 리스트와 자료형을 일치하게 변수를 만들어주고 형변환도 해준다.
            List<string> inlist2 = (List<string>)outlist2[6]; // { "f", "g", "h" }

            // 리스트에 담긴 값에 접근하기 위해 인덱스 사용
            Console.WriteLine(inlist2[2]); // h




            
        }
    }
}
