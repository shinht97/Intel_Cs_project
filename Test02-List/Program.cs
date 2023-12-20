//#define LIST
#define DICTION

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test02_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test02 proc = new Test02();

            proc.MainFunc();
        }
    }

    class Test02
    {
#if LIST
        void Func_ListTest()
        {
            ArrayList list = new ArrayList(); // list 객체 생성, 1차원 only

            list.Add(1);    // int
            list.Add(2.54); // double
            list.Add('a');  // char
            list.Add("안녕하세요");  // string => list에 들어가는 요소는 datatype을 가리지 않음

            for(int i = 0; i < list.Count; i++) // list.Count : list안에 있는 원소의 개수(멤버 변수)
            {
                Write($"{list[i]} ");
            }

            WriteLine();

            list.Remove('a'); // 원하는 원소를 list에서 제거

            list.Add(" 여러분");

            for (int i = 0; i < list.Count; i++) // list.Count : list안에 있는 원소의 개수(멤버 변수)
                Write($"{list[i]} ");

            WriteLine();

            list.Insert(2, 'b'); // 특정 위치에 원소 추가

            for (int i = 0; i < list.Count; i++) // list.Count : list안에 있는 원소의 개수(멤버 변수)
                Write($"{list[i]} ");

            WriteLine();

            ArrayList list1 = new ArrayList();
            // list1 = list; // 리스트 복사
            list1 = (ArrayList) list.Clone();

            for (int i = 0; i < list1.Count; i++) // list.Count : list안에 있는 원소의 개수(멤버 변수)
                Write($"{list1[i]} ");

            WriteLine();
        }
#endif

#if DICTION
        void Func_DictionaryTest()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>(); // 타입을 지정하여 객체 생서

            dict.Add("1", "a");
            dict.Add("2", "b");
            dict.Add("3", "c");
            dict.Add("4", "d");

            Write($"{dict["1"]}, {dict["2"]}, {dict["3"]}, {dict["4"]}");

            WriteLine();
        }
#endif

        public void MainFunc()
        {

#if LIST
            Func_ListTest();
#endif

#if DICTION
            Func_DictionaryTest();
#endif

        }

        
    }
}
