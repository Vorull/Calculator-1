using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.cs
{
    class Log
    {
        /// <summary>
        /// основание логорифма
        /// </summary>
        double a=1;
        /// <summary>
        /// подлогорифмическое выражение
        /// </summary>
        double b=1;
        /// <summary>
        /// значение log
        /// </summary>
        double value=1;
        /// <summary>
        /// если true, то заполнен верно 
        /// </summary>
        public double A
        {
            get { return a; }
            set { if (value > 0) a = value; else a = 1; }
        }
        /// <summary>
        /// Получение/заполение под. лог. выраж.
        /// </summary>
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; else  b = 1;  }
        }
        /// <summary>
        /// Получить значение log
        /// (присваивать значения нельзя/только получить)</summary>
        public double Value
        {
            get { double buf;buf = Math.Log(a)/Math.Log(b); return buf; }
        }
       
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Log()
        {
            this.A = 1;
            this.B = 1;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="A">основание</param>
        /// <param name="B">под. лог. выражение</param>
        public Log(double A, double B)
        {
            this.A = A;
            this.B = B;
        }
       

    }
    


    
}


