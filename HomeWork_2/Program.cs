using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Задание #1
        // Изучить String и StringBuilder
        // Реализовать программу, которая выводит на экран текущее время
        // в зависимости от времени приветствует пользователя
        // (доброе утро, добрый день)
        public static string StartProgram()
        {
            DateTime timeNow = DateTime.Now;
            int hour = timeNow.Hour;

            StringBuilder result = new StringBuilder(String.Format("Сейчас {0}, Skynet желает ", timeNow.ToShortTimeString()));
            if (hour >= 5 && hour < 12)
                result.Append("доброго утра");
            else
                if (hour >= 12 && hour < 18)
                    result.Append("доброго дня");
                else
                    if (hour >= 18 && hour < 23)
                        result.Append("доброго вечера");
                    else result.Append("доброй ночи!!");
            return result.ToString();
        }

   
    }
}
