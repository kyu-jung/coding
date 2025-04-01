using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 자료형_심화
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T>
            // 배열과 차이점 : 크기가 동적으로 변함

            // List 선언의 형태
            // List<자료형> 변수 = new List<자료형> ();
            List<string> 학교 = new List<string>();

            string 변수;

            // 초기화
            변수 = "초기화";


            // Add(추가할 개체)
            // Add는 만들어진 리스트에 가장 뒤에 값이 붙는다.
            학교.Add("한국");
            학교.Add("폴리텍");
            학교.Add("아산");
            학교.Add("캠퍼스");


            // Count  -> 리스트에 있는 개체의 수를 세어 줌.
            for (int i = 0; i < 학교.Count; i++)
            {
                Console.WriteLine(학교[i]); // 인덱스로 접근해야 출력이 가능함.
            }



            //선언과 동시에 초기화
            // List<자료형> 변수 = new List<자료형> {초기화할 값};
            List<string> 학교2 = new List<string> { "한국", "폴리텍", "아산", "캠퍼스" };

            string 변수2 = "초기화";



            // 1. 정수형 리스트를 선언
            // 2. 정수형 리스트를 초기화
            // 3. 정수형 리스트를 선언과 동시에 초기화

            List<int> 정수형 = new List<int>();

            정수형.Add(1);
            정수형.Add(2);
            정수형.Add(3);
            정수형.Add(4);
            정수형.Add(5);
            정수형.Add(6);
            정수형.Add(7);
            정수형.Add(8);
            정수형.Add(9);
            정수형.Add(10);

            for (int i = 0; i < 정수형.Count; i++)
            {
                Console.WriteLine(정수형[i]);
            }



            List<int> 정수형2 = new List<int> { 1, 2, 3, 4, 5 };

            // 초기화한 값을 확인하기 위해서는 반복문을 통해 출력하여 확인해야함.
            for (int i = 0; i < 정수형2.Count; i++)
            {
                Console.WriteLine(정수형2[i]);
            }


            Console.WriteLine();
            Console.WriteLine();
            // Insert(위치, 값) (삽입)
            // Insert는 해당 위치에 자리를 만들어 값을 집어 넣는다.
            정수형.Insert(1, 9);
            Console.WriteLine(정수형[1]);
            Console.WriteLine(정수형.Count);

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 정수형.Count; i++)
            {
                Console.WriteLine(정수형[i]);
            }



            Console.WriteLine();
            Console.WriteLine();
            // Remove(제거할 개체)
            // 리스트에서 가장 먼저 발견되는 값을 제거. 없는 값을 입력하면 변화가 없음 (false처리됨)
            // 맨 처음 발견되는 특정 개체를 제거함. 
            정수형.Remove(9);
            Console.WriteLine(정수형.Count);

            for (int i = 0; i < 정수형.Count; i++)
            {
                Console.WriteLine(정수형[i]);
            }


            Console.WriteLine();
            Console.WriteLine();
            // RemoveAt(제거할 개체의 위치)
            // 
            정수형.RemoveAt(1);

            Console.WriteLine(정수형.Count);

            Console.WriteLine(string.Join(" ", 정수형));



            Console.WriteLine();
            // Sort()
            // Reverse()
            정수형.Sort(); // 오름차순 정렬
            정수형.Reverse(); // 리스트의 순서를 뒤집는다.


            // 오름차순으로 정렬한 리스트를 뒤집어서 출력 (내림차순)
            Console.WriteLine(string.Join(" ", 정수형));



            Console.WriteLine();
            // IndexOf
            Console.WriteLine(정수형.IndexOf(3));




            // Clear
            Console.WriteLine();
            정수형.Clear();
            Console.WriteLine(정수형.Count);


            



            // Add,  Insert,   Remove,  RemoveAt,  IndexOf,  Reverse,  Clear,  Count




            // 1. 정수형 리스트를 만들고 값을 추가해보도록 합니다. 1,2,3  -> 선언후 Add
            // 2. 요소들을 가지고 사칙연산을 해봅시다. 결과값은 $"{변수[위치]} + {변수[위치]} = {변수[위치]+변수[위치]}"
            // 3. 요소들에 새롭게 값을 삽입하고 값은 10, 20, 30을 넣어봅시다.
            // 4. 반복문을 통해 요소들을 확인해 봅시다. 변수.Count 사용
            // 5. 조건문을 사용해서 리스트 값이 5개 이하면 "더 추가해주세요.", 10개 이하면 "충분합니다.",
            //    나머지는 "리스트 완성" 출력

            List<int> 정수 = new List<int>();

            정수.Add(1);
            정수.Add(2);
            정수.Add(3);


            Console.WriteLine($"{정수[1]} + {정수[2]} = {정수[1] + 정수[2]}");
            Console.WriteLine($"{정수[1]} - {정수[2]} = {정수[1] - 정수[2]}");
            Console.WriteLine($"{정수[0]} * {정수[2]} = {정수[1] * 정수[2]}");
            Console.WriteLine($"{정수[0]} / {정수[2]} = {정수[0] / 정수[2]}");


            정수.Insert(1, 10);
            정수.Insert(3, 20);
            정수.Insert(0, 30);

            Console.WriteLine();
            for (int i = 0; i < 정수.Count; i++)
            {
                Console.WriteLine(정수[i]);
            }


            Console.WriteLine();
            if (정수.Count<=5)
            {
                Console.WriteLine("더 추가해주세요.");
            }

            else if (정수.Count <= 10)
            {
                Console.WriteLine("충분합니다.");
            }
           

            else
            {
                Console.WriteLine("리스트 완성");
            }



            // Contains (값) -> 값이 포함되어 있는지 확인
            if (정수.Contains(10))
            {
                Console.WriteLine($"10이라는 값은{정수.IndexOf(10)}에 위치하고 있습니다.");
            }

            else
            {
                Console.WriteLine($"10이라는 값은 없습니다.");
            }
          
        }
    }
}
