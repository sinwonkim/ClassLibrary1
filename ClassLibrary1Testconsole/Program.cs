using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Tools; //클래스 라이브러리의 툴 포함 시킴 

namespace ClassLibrary1Testconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClassLibrary1.Tools.Application.Root);
            Console.ReadLine(); //컴파일 시키면 ClassLibray1이 있는 위치 리턴되서 cmd 창으로 보여지지 
        }
    }
}
