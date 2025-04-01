using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_str
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자형 자료형 공부
            char a = 'A';
            Console.WriteLine("첫"+ a);

            //string 자료형 공부
            string hello = "Hello Asan";
            Console.WriteLine("안녕 아산 :" + hello);

            //string 연결하기 공부
            string name = "최규정";
            string check = " 첫 수업 출석";
            Console.WriteLine(name + check);

            //string 길이 알아보기
            int len = name.Length;
            Console.WriteLine(len);

            //string 글자 자르기
            string sub = hello.Substring(0, 2);
            Console.WriteLine(sub);


            //string 글자 대체하기
            string rephello = hello.Replace("Asan", "Seoul");
            Console.WriteLine(rephello);

            //string 글자 잘라서 표현하기
            string data = "사과,바나나,오렌지";
            string[] fruitlist = data.Split(',');

            foreach (var item in fruitlist)
            {
                Console.WriteLine("과일 : " + item);
            }

            //문장안에 문장 작은 따옴표편 ('')
            string longstr = "안녕하세요 오늘은 'C# 기초'를 수업하고 있습니다";
            Console.WriteLine(longstr);

            //문장안에 문장 탈출문자편 (\)
            string longstr2 = "안녕하세요 오늘은 \"C# 기초\"를 수업하고 있습니다";
            Console.WriteLine(longstr2);

        }
    }
}
