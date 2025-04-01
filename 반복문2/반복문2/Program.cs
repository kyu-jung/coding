using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 반복문2
{
    class Program
    {
        static void Main(string[] args)
        {
            // for 문
            // for(시작점; 목표와 비교; 증감++,--or할당+=,-=연산자)
            for (int i = 1; i <= 5; i++) // i++ -> i = i + 1
            { 
                Console.WriteLine($"반복문이 {i}회 실행되었습니다.");
            }



            // 반복문 for를 이용해서 0부터 10까지 1씩 증가하는 숫자를 출력하는 프로그램을 만들어봅시다.
            for (int i = 0; i <=10; i++) 
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            // 10부터 0까지 1씩 줄어드는 프로그램
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Console.WriteLine();
            // 홀수 오름차순 
            for (int i = 1; i >= 10; i += 2) 
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Console.WriteLine();
            //홀수일때 출력이 되도록 설계
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 1)  // i를 2로 나눴을때 나머지가 1인경우 출력
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine();
            Console.WriteLine();
            // 조건이 항상 참이면 반복문은 계속 실행된다.
            // break를 만나면 해당 구문을 탈출
            for (int i = 0; ; i++)
            {
                Console.WriteLine(i);
                if (i==10)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            // while
            // 조건이 참인 동안 항상 반복. 내부에서 false가 될수 있는 조건을 걸어준다.
            // 반복횟수를 알 수 없을때 사용
            int 조건 = 0;
            while (조건<10)
            {
                Console.WriteLine($"지금 조건은 {조건}입니다.");
                조건++; 
            }


            Console.WriteLine();
            Console.WriteLine();
            // while을 사용해서 0부터 20까지 숫자를 출력하는 프로그램을 만들어봅시다.
            int 숫자조건 = 0;
            while (숫자조건 <= 20)
            {
                Console.WriteLine(숫자조건);
                숫자조건++;
            }


            Console.WriteLine();
            Console.WriteLine();
            // do - while
            // while문과 유사하지만, 조건을 검사하기 전에 먼저 실행됨.
            // 최소 1번은 반드시 실행됨. 무조건 한번 실행해야하는 코드가 있을때 사용.
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 10);


            Console.WriteLine();
            Console.WriteLine();
            // foreach문
            // 배열이나 리스트의 요소를 차례대로 가져올때 사용.
            // for문보다 간결하고, 반복횟수를 직접 설정할 필요 없음

            string[] 과일 = { "바나나", "사과", "딸기" };

            foreach (var s in 과일)
            {
                Console.WriteLine(s);
            }


            // 숫자 배열을 만들고 1부터 10까지 담아주고
            // foreach를 사용해서 하나씩 출력해봅시다.

            int[] 숫자 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var b in 숫자)
            {
                Console.WriteLine(b);
            }


            Console.WriteLine();
            Console.WriteLine();
            // break와 continue
            // break를 만나면 해당 구문 탈출
            // break를 거는 위치가 중요. 5까지 출력하고 싶을때, 출력을 한 후 if문 break를 걸면 5 출력
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            // continue  한줄 건너뛰기 기능
            // continue 를 만나면 그 부분만 건너뜀.
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Console.WriteLine();
            // 중첩 반복문
            // 반복문 안에 또 다른 반복문을 만들어 사용
            // 구구단 2단 만들기
            for (int i = 2; i < 3; i++)  // 이중 반복문을 위한 껍데기
            {
                for (int j = 1; j<10; j++)  // 1~9까지 출력
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
            }


            // 구구단 3단 만들기
            for (int i = 3; i < 4; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
            }


            Console.WriteLine();
            Console.WriteLine();
            // 2단 부터 9단까지
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
            }
        }
    }
}
