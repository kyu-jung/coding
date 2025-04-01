using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    class Program
    {
        static void Main(string[] args)
        {
            // if 문
            // 주어진 조건이 true일때 코드 실행. 조건이 false이면 실행되지 않고 넘어감
            int 나이 = 20;
            if (나이 > 20)
            {
                Console.WriteLine("성인입니다.");
            }
            
            
            // else if 문
            // 조건이 많은경우 갯수를 늘릴수 있음.
            else if (나이 == 20)
            {
                Console.WriteLine("20살 입니다.");
            }

           
            // if - else 문
            else
            {
                Console.WriteLine("20살이 아닙니다.");
            }



            // 점수 85점을 초기화 합니다.
            // 90점이상은 "A학점", 80점 이상은 "B학점", 70점 이상은 "C학점" 나머지는 "D학점"
            int 점수 = 85;
            if (점수 >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (점수 >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (점수 >= 70)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("D학점");
            }


            // switch (변수) {case :    출력;   break;     default :   출력 ;      break ;}
            string 요일 = "토요일";
            switch (요일)
            {
                case "월요일":
                    Console.WriteLine("월요일입니다");
                    break;
                case "화요일":
                    Console.WriteLine("화요일입니다");
                    break;
                case "수요일":
                    Console.WriteLine("수요일입니다");
                    break;
                case "목요일":
                    Console.WriteLine("목요일입니다");
                    break;
                case "금요일":
                    Console.WriteLine("금요일입니다");
                    break;
                default:
                    Console.WriteLine("주말입니다");
                    break;
            }


            // 무지개 초기화는 마음에 드는 색
            // case 빨 주 노 초 파, default 남 보
            // Console.WriteLine("빨간색입니다");
            // Console.WriteLine("남색 또는 보라색입니다");


            // switch 문에서 goto사용    -> 특정 case로 이동.
            string 무지개 = "노란색";
            switch (무지개)
            {
                case "빨간색":
                    Console.WriteLine("빨간색입니다");
                    break;
                case "주황색":
                    Console.WriteLine("주황색입니다");
                    break;
                case "노란색":
                    Console.WriteLine("노란색입니다");
                    goto case "파란색";
                    break;
                case "초록색":
                    Console.WriteLine("초록색입니다");
                    break;
                case "파란색":
                    Console.WriteLine("파란색입니다");
                    break;
                default:
                    Console.WriteLine("남색 또는 보라색입니다");
                    break;
            }

           



        }
    }
}
