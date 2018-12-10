using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // 네임스페이스 IO쪽 추가 시켜놈 

namespace ClassLibrary1.Tools
{
    public class LogManager // 클래스는 퍼블릭으로 해놔야 하고 
    {
        private String _path;

        #region Constructors
        public LogManager(String path)
        {
            _path = path;
            _SetLogPath();
        }

        public LogManager() //로그 매니저 호출
            : this(Path.Combine(Application.Root, "Log"))
        {
        }
        #endregion

        #region Methods
        private void _SetLogPath() // 
        {
            if (Directory.Exists(_path))  //파일 없으면 생성해라 
                Directory.CreateDirectory(_path);

            string logFile = DateTime.Now.ToString("yyyyMMdd" ) +".txt";
            _path = Path.Combine(_path, logFile);

        }

        
        public void Write(String data)
        {
            try
            {

            
                // using 선언해서 하면 using 안에서만 작동하고 영역 벗어나면 resource 자동으로 해제 해줌 
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.Write(data);
                }
            }
            catch(Exception ex)
            {
          
            }
        }
        
        public void WriteLine(String data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss/t") + data);
                }
            }
            catch(Exception ex)
            {

            }

        }
        #endregion
    }
}
