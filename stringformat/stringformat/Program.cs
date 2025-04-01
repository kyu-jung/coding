using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stringformat
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 더하기
            string 더하기 = "한국";
            string 문자열 = "폴리텍";

            Console.WriteLine(더하기 + 문자열);


            // string.Format()
            string 이름 = "최규정";
            int 개수 = 1;
            string 자기소개 = string.Format("{0}은 사과를 {1}개 먹었다.", 이름, 개수);
            Console.WriteLine(자기소개);


            // {한국} {폴리텍} {1}교시 수업은 {C#}이라는 문자열을
            // 변수 4개를 선언하고 string.Format을 사용해서 문장을 만들어 봅시다.

            string 나라 = "한국";
            string 학교 = "폴리텍";
            int 시간 = 1;
            string 수업 = "C#";

            string 수업안내 = string.Format("{0}{1} {2}교시 수업은 {3}", 나라, 학교, 시간, 수업);
            Console.WriteLine(수업안내);


            // 보간문자열 $ 
            string 포맷 = $"{나라}{학교} {시간}교시 수업은 {수업}";
            Console.WriteLine(포맷);


            // $를 사용해서 변수 3개를 집어넣겠습니다.
            // 이번 시간은 {C#} 수업 진행중 {포맷 $}을 배우는 중 {완료}
            string 언어 = "C#";
            string 기능 = "포맷 $";
            string 확인 = "완료";

            // $@를 사용하면 여러줄로 표현할 수 있다.
            string 문장 = $@"이번 시간은 {언어} 수업 진행중  

{기능}을 배우는 중 {확인}";
            Console.WriteLine(문장);



            // stringbuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("안녕하세요");
            sb.Append(".");
            sb.Append(" 반갑습니다");
            sb.Append(".");
            sb.AppendLine("한줄쓰기");  // 엔터를 친것과 같은 기능
            sb.Append("이어쓰기");

            Console.WriteLine(sb.ToString());

            // StringBuilder를 이용해서 문자를 이어붙이도록 하겠습니다.
            // 한국 폴리텍
            // 아산 캠퍼스 수업중
            sb.AppendLine();
            sb.Append("한국");
            sb.AppendLine("폴리텍");
            sb.Append("아산");
            sb.Append("캠퍼스");
            sb.Append("수업중");

            Console.WriteLine(sb.ToString());


            // string.Join()
            // 배열 또는 리스트 문자열 합치기
            string[] 단어 = { "한국", "폴리텍", "아산", "캠퍼스" };
            int[] 숫자 = { 1, 2, 3, 4, 5, 6 };
            double[] 소수점 = { 1.23, 4.56, 7.89 };

            string 합치기 = string.Join("+",단어);  // string.Join("문자열", 원하는 배열(오브젝트))
            Console.WriteLine(합치기);
            string 합치기2 = string.Join("-", 숫자);
            Console.WriteLine(합치기2);
            string 합치기3 = string.Join(",", 소수점);
            Console.WriteLine(합치기3);


            // Join을 사용하고 문자열 "+-*/"로 해주고
            // 배열은 string "지금""Join""수업""진행중"

            string[] 연습 = { "지금", "Join", "수업", "진행중" };

            string 합치기4 = string.Join("+-*/", 연습);

            Console.WriteLine(합치기4);


            // string.Concat()  -> 더하기와 기능이 같다.
            // string.Concat(문자열 배열);
            Console.WriteLine(string.Concat(연습));


            //ToString()


            // 숫자, 날짜 등 특정 형식을 적용할때 사용
            // N2 - 소수점 2자리 표시(자동반올림), C - 통화(돈) 기호 표시, P - 퍼센트 표시
            double 소수점2 = 123.456;
            Console.WriteLine(소수점2);  // 소수인 숫자
            Console.WriteLine(소수점2.ToString());  // 문자로 형변환
            Console.WriteLine(소수점2.ToString("N2"));

            Console.OutputEncoding = Encoding.UTF8;  // "국제문자를 가져와서 사용하겠습니다"를 선언하는 기능
            Console.WriteLine(소수점2.ToString("C"));
            Console.WriteLine(소수점2.ToString("P1"));



            // int 형변환 = 45;
            // ToSting()에서 C와 P사용해보기
            int 형변환 = 45;
            Console.WriteLine(형변환.ToString());
            Console.WriteLine(형변환.ToString("C"));
            Console.WriteLine(형변환.ToString("P0"));



        }
    }
}
