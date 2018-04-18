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
            set { if ((value > 0)&&(value!=1)) a = value; else a = 2; }
        }
        /// <summary>
        /// Получение/заполение под. лог. выраж.
        /// </summary>
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; else  b = 2;  }
        }
        /// <summary>
        /// Получить значение log
        /// (присваивать значения нельзя/только получить)</summary>
        public double Value
        {
            //set не сделан по причине того, что пришлось бы вычислять новые a b 
            get { double buf;buf = Math.Log(b)/ Math.Log(a); return buf; }
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
        ///////////////////////////ОПЕРАЦИИ_ТИПА_ЛОГОРИФМ-ЛОГОРИФМ/////////////////////////////////////////////
        /// <summary>
        /// сложение логорифмов (рузультат в double)
        /// </summary>
        /// <param name="slag1">перрвое слагаемое</param>
        /// <param name="slag2">второе слагаемое</param>
        /// <returns></returns>
        public static double operator +(Log slag1, Log slag2)
        {
            //переменная под возвращаймое значение
            double buf = 0;
            buf = slag1.Value + slag2.Value;
            return buf;
        }
        /// <summary>
        /// Вычетание логорифмов (рузультат в double)
        /// </summary>
        /// <param name="slag1">Первое лагаемое</param>
        /// <param name="slag2">Второе лагаемое</param>
        /// <returns></returns>
        public static double operator -(Log slag1, Log slag2)
        {
            //переменная под возвращаймое значение
            double buf = 0;
            buf = slag1.Value - slag2.Value;
            return buf;
        }
        /// <summary>
        /// Деление логорифмов
        /// </summary>
        /// <param name="slag1">Делимый логорифм</param>
        /// <param name="slag2">логорифм делитель</param>
        /// <returns></returns>
        public static double operator /(Log slag1, Log slag2)
        {
            //переменная под возвращаймое значение
            double buf = 0;
            //проверка деления на ноль
            if (slag2.Value != 0)
            {
                buf = slag1.Value / slag2.Value;
                return buf;
            }
            //случай деление на ноль
            else
            {
                buf = 0;
                return buf;
            }
            
        }
        /// <summary>
        /// Произведение логорифмов 
        /// </summary>
        /// <param name="slag1">множитель логорифм</param>
        /// <param name="slag2">множител логорифм</param>
        /// <returns></returns>
        public static double operator *(Log slag1, Log slag2)
        {
            //переменная под возвращаймое значение 
            double buf = 0;
            buf = slag1.Value * slag2.Value;
            return buf;
        }

    }
    
    


    
}


