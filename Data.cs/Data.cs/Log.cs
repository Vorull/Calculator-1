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
        double a;
        /// <summary>
        /// подлогорифмическое выражение
        /// </summary>
        double b;
        /// <summary>
        /// значение log
        /// </summary>
        double value;
        /// <summary>
        /// если true, то заполнен верно 
        /// </summary>
        bool flag;
        //Свойства 
        /// <summary>
        /// Получение/заполение основания
        /// </summary>
        public double A
        {
            get { return a; }
            set { if (value > 0) a = value; }
        }
        /// <summary>
        /// Получение/заполение под. лог. выраж.
        /// </summary>
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Log()
        {

        }
    

    }


    
}


