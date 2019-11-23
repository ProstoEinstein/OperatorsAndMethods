using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorsAndMethods;

namespace StudentClassConsole
{
    class Program
    {
        /// <summary>
        /// Class Test Console Application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student student1 = new Student("Иванов", "Иван", "Иванович", 1);
            Student student2 = new Student("Игнатова", "Мария", "Александровна", 1);

            Console.WriteLine($"Рейтинг до повышения студента: \n{student1}");

            ++student1;
            Console.WriteLine($"Рейтинг после повышения студента: \n{student1}");

            --student1;
            Console.WriteLine($"Рейтинг после понижения студента: \n{student1}");


            double avatageMarkStudent1 = 7.8;
            double avatageMarkStudent2 = 6.7;

            student1.SetAverageMark(avatageMarkStudent1);
            student2.SetAverageMark(avatageMarkStudent2);

            if (student1 != student2)
            {
                Console.WriteLine("Равны");
            }
            else
            {
                Console.WriteLine("Не равны");
            }


            if (student1 == student2)
            {
                Console.WriteLine("Равны");
            }
            else
            {
                Console.WriteLine("Не равны");
            }

            if (!student1.Equals(student2))
            {
                Console.WriteLine("Не равны");
            }

            string strTorevers = "Hello world!";
            Console.WriteLine(strTorevers.ReverseString());
            Console.ReadKey();
        }
    }
}
