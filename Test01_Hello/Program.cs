//#define CONSOLE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test01_Hello
{
    internal class Program
    {
        static void Main(string[] args) // class Program의 멤버 함수이긴하나 독립되어 완성된 객체로 취급
        {
            Test01 sub = new Test01(); // Main안에서는 실제로 동작하는 class를 객체로 생성하는 것만으로 기능 끝!

            sub.mainFunc();
        }
    }

    class Test01 // main working class
    {
        // 프로그램의 실제 동작을 working class안에서 작성

        //public Test01() // 생성자
        //{
        //    Console.WriteLine("Hello World!");
        //}

        // 생성자와 소멸자가 따로 명시 되어 있지 않으면 Compiler가 자동으로 생성하여 사용

        public void mainFunc() // 멤버 함수
        {
            int i = 10, j = 20;
            double d = 1.5, e = 3.1;
#if CONSOLE
            WriteLine("Hello World({0})\nMain Function({1}, {0})", i, j); // printf와 동일

            while (true)
            {
                Write("두 정수 입력 : ");

                string str = ReadLine(); // 문자열 입력
                                         // ReadLine()은 string(datatype)을 반환
                try // 예외 처리
                {
                    i = int.Parse(str.Split()[0]); // string 객체의 멤버 함수
                                                   // .Split("자를 기준 문자 default : ' '") => 배열 반환

                    j = int.Parse(str.Split()[1]); // int 객체의 멤버 함수 Parse()

                    WriteLine($"입력한 정수는 ({i:D3}, {j}) 입니다."); // {0}, {1} 같은 인덱스를
                                                                           // 사용하지 않고 보간문자열로 출력
                }
                catch // 예외가 발생한 경우
                {
                    WriteLine("잘못된 입력");
                    break;
                }

                Write("두 실수 입력 : ");

                str = ReadLine();

                try
                {
                    d = double.Parse(str.Split()[0]);
                    e = double.Parse(str.Split()[1]);

                    WriteLine($"입력한 실수는 ({d:F3}, {e}) 입니다.");
                }
                catch (Exception exc)
                {
                    WriteLine($"오류 : {exc.Message}");
                    break;
                }
            }
#endif

            object o = i + 1; // object : 모든 datatype 객체의 최상위 class
            
            WriteLine($"Object : {o}, {o.GetType()}");

            o = d + 0.5;

            WriteLine($"Object : {o}, {o.GetType()}"); // object는 실제로 존재하는 객체

            var v = i + 1;

            WriteLine($"Var : {v}, {v.GetType()}");

            //v = d + 0.5; v는 이미 int 형으로 결정 되었기 때문에 불가능함
        }
    }
}
