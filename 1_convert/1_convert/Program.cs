using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 암시적 형변환
            // 작은 자료형(해당 개념이 포함되어 있는)
            // 큰자료형(작은 자료형을 포함하고 상위 단계의 개념)
            int 작은숫자 = 1;
            double 큰숫자;
            큰숫자 = 작은숫자;

            Console.WriteLine(작은숫자);
            Console.WriteLine(작은숫자.GetType());
            Console.WriteLine(큰숫자);
            Console.WriteLine(큰숫자.GetType());

            object 부모 = "부모님";
            string 자식 = "자식";

            부모 = 자식;

            //2. 명시적 형변환
            작은숫자 = (int)큰숫자;
            자식 = (string)부모;

            Console.WriteLine(작은숫자);
            Console.WriteLine(자식);

            //1. object를 이용하여 변수 "큰것"에 123.45를 넣고
            //2. double를 이용하여 변수 "소수점"에 -1.23를 넣고
            //3. 서로 값을 형변환하여 넣어주기
            //4. 출력하기

            object 큰것 = 123.45;
            double 소수점 = -1.23;

            큰것 = 소수점;
            소수점 = (double)큰것;

            Console.WriteLine(큰것);
            Console.WriteLine(소수점);


            //3. convert 클래스 사용

            string 문자숫자 = "123";
            int 숫자 = 0;

            숫자 = Convert.ToInt32(문자숫자);

            Console.WriteLine(숫자);
            Console.WriteLine();

            // 1. string 강제변환 변수를 만들고 999.99를 넣어준다.
            // 2. int 변수 "작은그릇"에 0으로 초기화               ->  오류가 나므로 double로 변경
            // 3. 작은그릇에 강제변환 값을 Convert.ToInt32로 변환  ->  오류가 나므로 Convert.ToDouble로 변경
            // 4. 출력한다.

            string 강제변환 = "999.99";
            double 작은그릇 = 0;

            작은그릇 = Convert.ToDouble(강제변환);

            Console.WriteLine(작은그릇);

            // 1. string을 이용하여 변수 "문자소수점"에 123.45를 넣고
            // 2. double를 이용하여 변수 "소수점2"에 0을 넣고 \
            // 3. Convert를 이용하여 소수점2에 문자소수점 값을 형변환해서 넣고
            // 4. 출력하기

            string 문자소수점 = "123.45";
            double 소수점2 = 0;

            소수점2 = Convert.ToDouble(문자소수점);

            Console.WriteLine(소수점2);


            //4. parse 사용

            string 파이 = "3.14";
            double pi;
            pi = double.Parse(파이);
            Console.WriteLine(pi);


            // 1. string 에 변수"형변환", 값 100
            // 2. int에 변수 "체인지" 선언만
            // 3. 체인지에 형변환 변수 값을 .Parse로 변환하여 대입하고 출력

            string 형변환 = "100";
            int 체인지;
            체인지 = int.Parse(형변환);
            Console.WriteLine(체인지);


            //5. TryParse 사용

            string 파이2 = "3.14";
            bool 판단;
            판단 = int.TryParse(파이2, out int 결과값);
            Console.WriteLine(판단);
            Console.WriteLine();

            // 1. string 변수 "plc" 값은 100을 넣는다.
            // 2. bool 참거짓 선언
            // 3. 참거짓에 int.TryParse를 사용하고 out int에 "결과" 변수로 값을 받아준다.
            // 4. 참거짓과 결과를 출력하기

            string plc = "100";
            bool 참거짓;
            참거짓 = int.TryParse(plc, out int 결과);
            Console.WriteLine(참거짓);
            Console.WriteLine(결과);
        }
    }
}
