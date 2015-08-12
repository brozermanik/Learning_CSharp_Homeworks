using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Задание #1
        // Даны значения числа Пи = 3,141592653 и числа Эйлера е = 2,7182818284590452
        // Реализовать вывод на экран значения без потери точности
        static void ExerciseOneDisplayPiE()
        {
            double pi = 3.141592653d;
            decimal e = 2.7182818284590452m;

            Console.WriteLine("Число Пи = {0}", pi);
            Console.WriteLine("Число е(Эйлера) = {0}", e);

            Console.ReadKey();
        }

        // Задание #2
        // Реализовать простой калькулятор: пользователь вводит 2 числа,
        // Программа выводит результат их сложения
        static void ExerciseTwoSum()
        {
            double a;
            Console.WriteLine("Введите первую цифру: ");
            a = Convert.ToDouble(Console.ReadLine());

            double b;
            Console.WriteLine("Введите вторую цифру: ");
            b = Convert.ToDouble(Console.ReadLine());

            //double c = a + b;
            Console.WriteLine("{0:0.00}  +  {1:0.00} = {2:0.00}", a, b, a + b);
        }

        // Задание #3
        // Реализовать калькулятор решающий квадратные уравнения
        // Пользователь вводит значения для a,b,c программа выводит значения дискриминанта и х1 и х2
        static void ExerciseThreeSquares()
        {
            double xOne;
            double xTwo;

            // Получаем данные от пользователя
            double a;
            Console.WriteLine("Данная программа используется для решеня квадратных уравнений\nКвадратные уравнения имеют вид ax^2+bx+c=0\nВведите a: ");
            a = Convert.ToDouble(Console.ReadLine());

            double b;
            Console.WriteLine("Теперь введите b: ");
            b = Convert.ToDouble(Console.ReadLine());

            double c;
            Console.WriteLine("Теперь введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

            // Вычисляем дискриминант, если он равен 0, то вычисляем единственный корень
            // если d <0 - выводим сообщение о том, что уравнение не имеет вещественных корней
            // в ином случае выводим результаты
            double d;
            d = b * b - 4 * a * c;

            if (d == 0)
            {
                xOne = (-b / (2 * a));
                Console.WriteLine("Уравнение имеет 1 корень: X1 = {0:0.000}", xOne);
            }

            else if (d < 0)
            {
                Console.WriteLine("Уравнение не имеет вещественных корней");
            }

            else
            {
                Console.WriteLine("d = " + d);
                xOne = (-b + Math.Sqrt(Math.Abs(d))) / (2 * a);
                xTwo = (-b - Math.Sqrt(Math.Abs(d))) / (2 * a);
                Console.WriteLine("Ответ: X1 = {0:0.000}, X2 = {1:0.000}", xOne, xTwo);
            }
        }

        // Задание #4
        // Реализовать программу подсчета средней заработной платы
        // Пользователь вводит количество сотрудников и их зарплаты
        // программа выодит среднюю зп

        // Метод запускает программу
        public static void StartProgram()
        {
                int n;
                Console.WriteLine("Введите количество сотрудников");
                n = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Средняя зарплата равно: {0:0.00} руб.", SalaryDB(ref n));
                Console.ReadKey();
         }
         // метод подсчитыает среднюю зарплату из массива сотрудников и возвращает значение
         public static decimal SalaryDB(ref int n)
         {
                decimal[] salary = new decimal[n];
                int i = 0;
                while (i < n)
                {
                    Console.WriteLine("Введите зарплату сотрудника, в руб.");
                    salary[i] = Decimal.Parse(Console.ReadLine());
                    Console.WriteLine();
                    i++;
                }
                decimal avgSalary = salary.Average();
                return avgSalary;
          }
    }
}
