//#define CONSOLE
//#define OBJECT
//#define STATIC
//#define POINT


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // static class, 메모리에 상주해야 입출력이 가능

namespace Test01_Hello // 범위 지정 keyword
{

#if STATIC
    static class myLib
    {
        // public : 접근 지시자는 매번 붙혀줘야함

        public static string GetToken(string _str, int _n, char _sep) 
        {
            // (str) : "1 2 3" "1,2,3" , (n)번째, (seperator) : ',' ' '

            return _str.Split(_sep)[_n];
        }
    }
#endif

#if POINT
    class Point
    {
        double x, y;

        public Point(double x = 0, double y = 0) // defalut 값을 설정하여, null 생성자로도 가능하게 만들어줌
        {
            this.x = x;
            this.y = y;
        }

        public double Dist(Point _p1) 
        {
            double d1 = _p1.x - x;
            double d2 = _p1.y - y;

            return Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2));
        }

        public static double operator -(Point _p1, Point _p2) // 연산자 오버로딩
                                                              // 연산자의 역할을 바꿀 수 있음
        {
            double d1 = _p1.x - _p2.x;
            double d2 = _p1.y - _p2.y;

            return Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2));
        }

        public static double operator *(Point _p1, Point _p2) 
        {
            double d1 = Math.Abs(_p1.x - _p2.x); // Math.Abs() => 함수의 오버로딩 : 매개변수 타입이 여러개 가능
            double d2 = Math.Abs(_p1.y - _p2.y);

            return d1 * d2;
        }
    }
#endif

    internal class Program
    {
        static void Main(string[] args) // class Program의 멤버 함수이긴하나 독립되어 완성된 객체로 취급
        {
            Test01 sub = new Test01(); // Main안에서는 실제로 동작하는 class를
                                       // 객체로 생성하는 것만으로 기능 끝!

            sub.mainFunc(); // 객체의 멤버 함수 사용
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
            Console();
#endif

#if OBJECT
            OBJECT();
#endif

#if STATIC
            // myLib my = new myLib(); // static 선언을 하면 객체를 생성할 필요가 없음

            string str = ReadLine();

            i = int.Parse(myLib.GetToken(str, 0, ' ')); // 클래스 이름을 사용하여 바로 접근 가능
#endif

#if POINT
            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);

            WriteLine($"두 점 p1(10, 20)과 p2(30, 40)의 거리는 " +
                $"(Dist : {p1.Dist(p2):##.###}) [- : {p1 - p2:##.###}]");

            WriteLine($"두 점 p1(10, 20)과 p2(30, 40)이루는 사각형의 넓이는 {p1 * p2}");

            //string s1 = "Good";
            //string s2 = " Morning";
            //string s3 = s1 + s2;

            //WriteLine(s3);
#endif
            int[] arr = new int[i]; // new를 통해 객체를 생성하기 때문에 i(변수)를 통해 배열을 생성할 수 있음
            
            for(j = 0; j < i; j++)
            {
                arr[j] = j;
            }

            // arr : 배열 객체, arr[i] : int 객체
        }

#if CONSOLE
        void Console()
        {
            int i = 10, j = 20;
            double d = 1.5, e = 3.1;

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
        }
#endif

#if OBJECT
        void OBJECT()
        {
            int i = 10, j = 20;
            double d = 1.5, e = 3.1;

            object o = i + 1; // object : 모든 datatype class의 최상위 class

            WriteLine($"Object : {o}, {o.GetType()}"); // object는 실제로 존재하는 객체

            o = d + 0.5;

            WriteLine($"Object : {o}, {o.GetType()}"); // datatype의 최상위이기 때문에 어떠한
                                                       // 자료형이든 대입 할수 있음

            var v = i * 10; // datatype이 고정이나, 작성 당시에만 결정되지 않은 형

            WriteLine($"Var : {v}, {v.GetType()}");

            // v = d * 10; // v는 이미 int 형으로 결정 되었기 때문에 불가능함
            // v = j * 10; // 이 식은 j가 int이기 때문에 가능함

            WriteLine($"i : {i}, j : {j}, d : {d}, e : {e}, o : {o}");
            WriteLine($"i : {sizeof(int)}, j : {sizeof(int)}, d : {sizeof(double)}, e : {sizeof(double)}");
            // object는 여러 데이터 형을 대입 할 수 있기 때문에 크기를 출력할 수 없다
            // sizeof()는 변수가 아니라 데이터 형으로 구할 수 있다
        }
#endif

    }
}
