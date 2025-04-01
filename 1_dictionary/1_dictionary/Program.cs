using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();

            // 선언
            Dictionary<int, string> 사전 = new Dictionary<int, string>(); // key type : int, value type : string

            // 초기화
            사전.Add(1, "한국");
            사전.Add(2, "폴리텍");
            사전.Add(3, "아산");
            사전.Add(4, "캠퍼스");


            foreach (var item in 사전) // in 뒤에는 배열, 리스트, 딕셔너리
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            
            Console.WriteLine();
            // 선언과 초기화

            Dictionary<int, string> 초기화 = new Dictionary<int, string>()
            {
                { 1, "한국" }, { 2, "폴리텍" }, { 3, "아산" }, { 4, "캠퍼스" }
            };

            // Console.WriteLine(변수[키]);
            Console.WriteLine(초기화[1]);

            Console.WriteLine();
            // 초기화에 있는 요소들을 반복문을 통해 출력하기
            foreach (var item in 초기화)
            {
                Console.WriteLine(item.Key + "*" + item.Value);
            }

            // 없는 키를 접근하면 오류가 발생
            Console.WriteLine(사전[3]); // 아산

            Console.WriteLine();
            // 변수.TryGetValue(키, out Tvalue 변수)
            // 키가 있으면 변수에 해당하는 값을 받아옴. True
            // 없으면 아무것도 못받음. False
            if (사전.TryGetValue(5, out string result))
            {
                Console.WriteLine($"{result}이 있습니다.");
            }
            else
            {
                Console.WriteLine($"{result}이 없습니다.");
            }

            Console.WriteLine();
            // 변수.ContainsKey(키)
            // 키가 있는지 없는지 확인
            if (사전.ContainsKey(5))
            {
                Console.WriteLine($"{사전[5]}가 있습니다.");
            }
            else
            {
                Console.WriteLine("키가 없습니다.");
                사전.Add(5, "하이테크");
                Console.WriteLine(사전[5]);
            }

            Console.WriteLine();
            // 변수.ContainsValue(값)
            if (사전.ContainsValue("아무거나"))
            {
                Console.WriteLine("아무거나 값이 있습니다.");
            }
            else
            {
                Console.WriteLine("아무거나 값이 없습니다.");
               
            }


            Console.WriteLine();
            // 값 지우기
            사전.Remove(1);

            foreach (var item in 사전)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }


            Console.WriteLine();
            사전.Clear();
            Console.WriteLine(사전.Count);


            Console.WriteLine();
            // string, string 으로 딕셔너리 만들고
            // 월, plc/ 화 , C# / 수, 시퀀스 / 목, Python / 금, 캐드
            Dictionary<string, string> 요일 = new Dictionary<string, string> 
            {
                { "월", "plc" }, {"화" , "C#" }, {"수", "시퀀스" }, {"목", "Python" }, { "금", "캐드" }
            };
            foreach (var item in 요일)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.WriteLine();

            // 새로운 값 추가하기(토, 게임),(일, 운동)
           
            요일.Add("토", "게임");
            요일.Add("일", "운동");

            foreach (var item in 요일)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            
            // 화요일 값 지우기
            Console.WriteLine();
            요일.Remove("화");
            foreach (var item in 요일)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            
            // if 문으로 (수) 가 있으면 "시퀀스 수업 합니다" 출력
            Console.WriteLine();
            if (요일.ContainsKey("수"))
            {
                Console.WriteLine("시퀀스 수업 합니다");
            }


            // if 문으로 Value : winform이 있으면 "winform 수업중" 없으면 "winform 수업해주세요"
            Console.WriteLine();

            if (요일.ContainsValue("winform"))
            {
                Console.WriteLine("winform 수업중");
            }
            else
            {
                Console.WriteLine("winform 수업해주세요");
            }

            
            // if 문으로 (금, out string result2) 값이 있으면 "{result2} 출력" 없으면 "수업없음" 출력
            Console.WriteLine();

            if (요일.TryGetValue("금", out string result2))
            {
                Console.WriteLine($"{result2} 출력");
            }
            else
            {
                Console.WriteLine("수업없음");
            }



        }
    }
}
