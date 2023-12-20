//#define CONSOLE
//#define OBJECT
//#define STATIC
//#define POINT
//#define ARRAY
#define DELEGATE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // static class, 메모리에 상주하여야 입출력이 가능

namespace Test01_Hello // 범위 지정 keyword
{
    /* static */ class myLib
    {
        // public : 접근 지시자는 매번 붙혀줘야함

        public static string GetToken(string _str, int _n, char _sep) 
        // (str) : "1 2 3" "1,2,3" , (n)번째, (seperator) : ',' ' '
        // class가 static으로 선언 되었기 때문에 멤버 함수 또한 static으로 선언하여야 사용 가능
        {
            return _str.Split(_sep)[_n];
        }
    }

    class Point
    {
        double x, y;

        public Point(double x = 0, double y = 0) // defalut 값을 설정하여, 기본 생성자로도 가능하게 만들어줌
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
                                                              // 연산자의 기능을 바꿀 수 있음
        {
            double d1 = _p1.x - _p2.x;
            double d2 = _p1.y - _p2.y;

            return Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2));
        }

        public static double operator *(Point _p1, Point _p2) // static을 붙히면 클래스 정적 멤버가 됨,
                                                              // 클래스 이름을 통해서 호출할 수 있음
        {
            double d1 = Math.Abs(_p1.x - _p2.x); // Math.Abs() => 함수의 오버로딩 : 매개변수 타입이 여러개 가능
            double d2 = Math.Abs(_p1.y - _p2.y);

            return d1 * d2;
        }
    }

    internal class Program
    {
        static void Main(string[] args) // class Program의 멤버 함수이긴하나
                                        // static 선언을 통해 독립된 객체로 사용
        {
            Test01 sub = new Test01(); // Main안에서는 실제로 동작하는 class를
                                       // 객체로 생성하는 것만으로 기능 끝!

            // sub.mainFunc(); // 객체의 멤버 함수 사용
        }
    }

    class Test01 // real working class
    {
        // 프로그램의 실제 동작을 working class안에서 작성

        //public Test01() // 생성자
        //{
        //    Console.WriteLine("Hello World!");
        //}

        // 생성자와 소멸자가 따로 명시 되어 있지 않으면 Compiler가 자동으로 생성하여 사용

        public Test01() // 생성자 호출과 동시에 함수 실행
        {
            mainFunc();
        }

#if DELEGATE
        delegate void cbTest(/* argument */);

        void f1() { WriteLine("delegate Test 01"); }
        void f2() { WriteLine("delegate Test 02"); }
        void f3() { WriteLine("delegate Test 03"); }
#endif

        public void mainFunc() // 멤버 함수, 주 진입점(실행 함수)
        {
            int i = 10, j = 20; // datatype 조차 객체
            double d = 1.5, e = 3.1;

#if CONSOLE
            Func_ReadWrtie();
#endif

#if OBJECT
            Func_datatype()
#endif

#if STATIC
            // myLib my = new myLib(); // static 선언을 하면 객체로 생성할 필요가 없음

            string str = ReadLine();

            i = int.Parse(myLib.GetToken(str, 0, ' ')); // 클래스 이름을 사용하여 바로 접근 가능 
                                                        // => static이기 때문에 가능
#endif

#if POINT
            Func_Point();
#endif

#if ARRAY
            Func_Array();
#endif

#if DELEGATE
            Func_DelegateTest();
#endif
        }

#if CONSOLE
        public void Func_ReadWrtie()
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
        public void Func_datatype()
        {
            int i = 10, j = 20;
            double d = 1.5, e = 3.1;

            object o = i + 1; // object : 모든 datatype class의 최상위 class

            WriteLine($"Object : {o}, {o.GetType()}"); // object는 실제로 존재하는 객체

            o = d + 0.5; // datatype의 최상위이기 때문에 어떠한
                         // 자료형이든 대입 할수 있음

            WriteLine($"Object : {o}, {o.GetType()}"); 

            var v = i * 10; // datatype이 고정이나, 작성 당시에만 결정되지 않은 keyword

            WriteLine($"Var : {v}, {v.GetType()}");

            // v = d * 10; // v는 이미 int 형으로 결정 되었기 때문에 불가능함
            // v = j * 10; // 이 식은 j가 int이기 때문에 가능함

            WriteLine($"i : {i}, j : {j}, d : {d}, e : {e}, o : {o}");
            WriteLine($"i : {sizeof(int)}, j : {sizeof(int)}, d : {sizeof(double)}, e : {sizeof(double)}");
            // object는 여러 데이터 형이든 대입 할 수 있기 때문에 크기를 출력할 수 없다.
            // sizeof()는 변수가 아니라 데이터 형으로 구할 수 있다
        }
#endif

#if POINT
        void Func_Point()
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);

            WriteLine($"두 점 p1(10, 20)과 p2(30, 40)의 거리는 " +
                $"(Dist : {p1.Dist(p2):##.###}) [- : {p1 - p2:##.###}]");

            WriteLine($"두 점 p1(10, 20)과 p2(30, 40)이루는 사각형의 넓이는 {p1 * p2}"); // 함수 오버로딩

            //string s1 = "Good";
            //string s2 = " Morning";
            //string s3 = s1 + s2; // + 연산자의 오버로딩

            //WriteLine(s3);
        }
#endif

#if ARRAY
        void Func_Array()
        {
            //int i = 10;

            //int[] arr = new int[i]; // new를 통해 객체를 생성하기 때문에 i(변수)를 통해 가변 배열을 생성할 수 있음

            //for (int j = 0; j < i; j++) // 배열 초기화
            //{
            //    arr[j] = j;
            //}

            // arr : 배열 객체, arr[i] : int 객체

            Point[] p = new Point[10]; // class 배열 객체도 가능

            int[] arr = new int[10];
            int[] arr1 = { 10, 11, 12, 13, 14 }; // 선언과 초기화
            double[] drr = { 0.1, 1.1, 2.1, 3.1, 4.1 };

            // C#의 배열은 요소를 추가 할 수 있음
            WriteLine($"Length of [arr] : {arr.Length}");

            arr = arr.Append(10).ToArray();

            WriteLine($"Length of [arr] : {arr.Length}");

            // int[] arr2 = arr + arr2; // 배열의 경우는 직접 합칠수 없음

            WriteLine($"배열 요소의 합 : {ArrSum(arr1)}");
            WriteLine($"실수 배열 요소의 합 : {ArrSum(drr)}");

            PrintArr(arr1);

            // 문자열의 연결
            //string s1 = "Good ";
            //string s2 = "Morning";

            //WriteLine(s1 + s2); // 문자열은 합칠수 있음
            /*-------------------------------------------------------------------*/

            // 다차원 배열 선언 방법
            int[,] brr; // 한 차원의 크기가 동일한 경우 적합
            brr = new int[,] { { 0, 1, 2, 3, 4 }, { 10, 11, 12, 13, 14 } };

            int[][] crr; // 배열의 배열(포인터의 배열)
            crr = new int[][]
            {
                new int[] { 0, 1, 2, 3, 4}, // 각각의 요소가 새로운 배열 => 가변 => 문자열 처리에 유리
                new int[] { 10, 11, 12, 13, 14, 15, 16}
            };

            //for (int k = 0; k < brr.GetLength(0); k++)
            //{
            //    for (int l = 0; l < brr.GetLength(1); l++)
            //    {
            //        Write($"brr[{k}, {l}] : {brr[k, l],2} ");
            //    }
            //    WriteLine();
            //}

            //WriteLine();

            //for (int k = 0; k < crr.Length; k++)
            //{
            //    for(int l = 0; l < crr[k].Length; l++) // 각 요소의 길이로 인덱스 접근 가능
            //    {
            //        Write($"crr[{k}][{l}] : {crr[k][l],2} ");
            //    }
            //    WriteLine();
            //}
            /* --------------------------------------------------------------------- */

            //3차원 가변 배열
            //int[][][] four_D =
            //    {
            //        new int[][]
            //        {
            //            new int[] { 1, 2, 3, 4},
            //            new int[] { 5, 6, 7, 8}
            //        },
            //        new int[][]
            //        {
            //            new int[] { 9, 10, 11, 12},
            //            new int[] {13, 14, 15, 16},
            //            new int[] {17, 18, 19, 20, 21}
            //        }
            //    };

            //for(int k = 0;k < four_D.Length; k++)
            //{
            //    for(int l=0;  l < four_D[k].Length;l++)
            //    {
            //        for(int q = 0; q < four_D[k][l].Length;q++)
            //        {
            //            Write($"{four_D[k][l][q]} ");
            //        }
            //        WriteLine();
            //    }
            //    WriteLine();
            //}

            int[] earr;

            InitArr(out earr, 10); // 초기화되어야 사용가능(out을 사용하여 포인터를 넘기는 것처럼 사용)

            for(int k = 0; k < earr.Length; k++)
            {
                Write($"earr[{k}] : {earr[k]} ");
            }
                
            WriteLine();

            CallArr(earr);

            for (int k = 0; k < earr.Length; k++)
            {
                Write($"earr[{k}] : {earr[k]} ");
            }

            WriteLine();

            Array.Copy(earr, 2, crr[0], 0, 3);

            for (int k = 0; k < crr.Length; k++)
            {
                for (int l = 0; l < crr[k].Length; l++) // 각 요소의 길이로 인덱스 접근 가능
                {
                    Write($"crr[{k}][{l}] : {crr[k][l],2} ");
                }
                WriteLine();
            }
        }

        //int ArrSum(int[] _arr) // int 배열 요소의 합, 객체가 매개 변수 => 객체의 멤버를 모두 사용할 수 있음
        //{
        //    int sum = 0;

        //    for(int i = 0; i < _arr.Length; i++) // 배열객체의 멤버 변수(_arr.Length)를 통해 길이를 알 수 있음
        //    {
        //        sum += _arr[i];
        //    }

        //    return sum;
        //}

        T ArrSum<T>(T[] arr) // 배열 요소의 합을 구하는 Generic 함수(datatype과 상관 없는 범용 함수)
        {
            T sum = (dynamic) 0; // dynamic : 형식 상관 말고 사용

            foreach(dynamic a in arr)
            {
                sum += a;
            }

            return sum;
        }

        void PrintArr<T>(T[] arr)
        {
            int i = 0;
            foreach(T a in arr)
            {
                Write($"[{i++}] : {a} ");
            }
        }

        void InitArr(out int[] _arr, int n) // out keyword : 초기화되지 않은 변수를
                                            // 사용할 수 있도록 함(포인터 처럼 역할) 
        {
            _arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                _arr[i] = i;
            }

            //foreach(int a in _arr)
            //{
            //    _arr[a] = a;
            //}
        }

        void CallArr(int[] _arr) // 참조로 넘어옴(call by referance)
        {
            _arr[2] = 100;
            _arr[4] = 200;

            for (int k = 0; k < _arr.Length; k++)
            {
                Write($"earr[{k}] : {_arr[k]} ");
            }

            WriteLine();
        }
#endif

#if DELEGATE
        void Func_DelegateTest()
        {
            cbTest cb;

            cb = new cbTest(f1); cb();
            cb = new cbTest(f2); cb();
            cb = new cbTest(f3); cb();

            cbTest[] cb_list = new cbTest[3] { f1, f2, f3 }; // 대리자를 통한 함수의 배열을 만들수 있음

            foreach(cbTest c in cb_list)
            {
                c();
            }
        }

#endif

    }
}
