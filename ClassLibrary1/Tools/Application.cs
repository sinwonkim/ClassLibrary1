using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tools
{
    public static class Application
    {
        public static string Root
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory; 
                //Application클래스에서  Root 프로퍼티를 호출하면 폴더를 리턴해주면되지

            }
        }
    }
}
