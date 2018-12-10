﻿using System;
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
            LogManager log = new LogManager();

            log.WriteLine("-----------[Begin Processing]--------");

            for(int index = 0; index < 10; index++)
            {
                log.WriteLine("Processing : " + index);

                System.Threading.Thread.Sleep(500);

                log.WriteLine("Done : " + index);

            }

            log.WriteLine("--------[End Processing ]-------------");
        }
    }
}
