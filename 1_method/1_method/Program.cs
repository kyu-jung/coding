using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_method
{
    public class MathOperaor
    {
        // 11. 메서드 오버로딩(Method Overloading)
        // 같은 이름의 함수이고 매개변수 타입이나 개수를 다르게 하여 여러개 정의

        // 11-1. 곱하기 함수를 만듭니다. 반환형 정수, 매개변수 정수
        public int multiple(int int_input1, int int_input2)
        {
            return int_input1 * int_input2;
        }

        // 11-2. 곱하기 함수를 만듭니다. 반환형 실수, 매개변수 실수
        public double multiple(double dou_input1, double dou_input2)
        {
            return dou_input1 * dou_input2;
        }

        // 11-3. 곱하기 함수를 만듭니다. 반환형 정수, 매개변수 정수, 개수 추가
        public int multiple(int int_input1, int int_input2, int int_input3)
        {
            return int_input1 * int_input2 * int_input3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 함수의 기본형
            // 1. 반환 없음, 매개변수 없음
            void nothing() 
            {
                // 출력만 해줌, 단순 화면에 출력만 될뿐 우리에게 값을 주는 것이 아님
                Console.WriteLine("아무것도 없는 함수");
            }

            // 2. 함수 호출
            nothing();


            // 3. 반환없음, 매개변수 있는 함수
            void hello(string input)
            {
                Console.WriteLine($"값 : {input}");
            }

            hello("입력");

            // 4. 반환 있음, 매개변수 없음
            int Add()
            { 
                return 1 + 2;
            }

            Console.WriteLine(Add());
            int a = Add();

            // 5. 반환 있음, 매개변수 있음
            int Sub (int x, int y)
            {
                return x - y;
            }

            Sub(1, 2);
            Console.WriteLine(Sub(1, 2));



            // 1. 반환 없고, 매개 변수 없는 함수 만들기
            // 2. 반환 없고, 매개 변수 있는 함수 만들기
            // 3. 반환 있고, 매개 변수 없는 함수 만들기
            // 4. 반환 있고, 매개 변수 있는 함수 만들기

            void nothing2()
            {
                Console.WriteLine("연습하기");
            }
            nothing2();

            void quiz(string input)
            { 
                Console.WriteLine($"함수만들기 : {input}");
            }
            quiz("매개변수");

            int Add2()
            {
                return 123 + 456;
            }
            Console.WriteLine(Add2());

            int Sub2(int x, int y)
            {
                return x - y;
            }

            Console.WriteLine(Sub2(123, 456));


            // 6. 매개변수 기본값
            void sayhello(string name = "선생님")
            {
                Console.WriteLine($"안녕하세요.{name}님!");
            }

            sayhello(); // 기본값이 할당 되었기 때문에 매개 변수 안넣어도 됨
            sayhello("최규정"); // 기본값 대신에 매개 변수로 작용


            // 7. 매개변수 여러개, 기본값이 몇개만 있을 경우
            // 기본값이 적용되는 매개변수는 항상 맨 마지막에 와야함.

            void subject(string sub1, string sub2, string sub3 = "c#")
            {
                Console.WriteLine($"{sub1},{sub2},{sub3}");
            }

            subject("plc", "파이썬");


            // 8. ref키워드 (값을 참조로 전달)
            void DoubleNumber(ref int num) // reference
            {
                num *= 2; // num = num * 2;
            }

            void DoubleNumber2(int num)
            {
                num *= 2; // num = num * 2;
            }
            int value = 10;   
            int value2 = 10;

            DoubleNumber(ref value);   // value = int num;
            Console.WriteLine(value); // 20  함수 안에서 값이 변경되어서 함수 밖으로 출력됨

            DoubleNumber2(value2);
            Console.WriteLine(value2);  // 10  함수 안에서 값이 변경되지만 함수 밖에 나오면 값이 되돌아옴


            // 9. out키워드 (여러 개 반환 값 전달)
            // return, 반환은 자료형을 따라가지만 추가적으로 다른 자료형, 자료형이 여러개 반환 되어야 할 때 사용
            void divide(int aa, int bb, out int result1, out int result2)
            {
                result1 = aa / bb;
                result2 = aa % bb;
            }

            int cc, dd;
            divide(10, 2, out cc, out dd);

            Console.WriteLine($"{cc}, {dd}");



            // 10. params 키워드 (가변 인수)
            void printNumber(params int[] numbers)
            {
                foreach (var num in numbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            int[] int_arr = { 1, 2, 3, 4 };

            printNumber(1, 2, 3, 4, 5);
            printNumber(int_arr);

           
            // 11. 메서드 오버로딩(Method Overloading)
            // 같은 이름의 함수이고 매개변수 타입이나 개수를 다르게 하여 여러개 정의
            // class MathOperaor 에서 정의

            MathOperaor math = new MathOperaor();
            Console.WriteLine(math.multiple(1, 2));
            Console.WriteLine(math.multiple(1.12, 2.56));
            Console.WriteLine(math.multiple(1, 2, 6));



            // 12. 지역변수 vs 전역변수
            // 지역변수 : 메서드 내부에서만 사용
            // 전역변수 : 클래스 내에서 선언, 모든 메서드에서 사용 가능

            int count = 0;

            void increase()
            {
                int step = 1; // 메서드 내부에서만 사용
                count += step;
            }

            count = 3;
            increase();


            // 13. 재귀함수 (팩토리얼)
            // 함수가 자기 자신을 호출하는 함수
            // 재귀함수는 반드시 종료 조건이 있어야함
            // 종료 조건이 없으면 무한 루프에 빠짐

            int factorial(int x)
            {
                if (x == 1)
                {
                    return 1;
                }
                return x * factorial(x - 1);
            }

            Console.WriteLine(factorial(10));

        }
    }
}
