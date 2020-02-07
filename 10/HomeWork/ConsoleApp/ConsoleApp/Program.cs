using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            // Количество человек
            int count = 3;

            Person[] person = new Person[count];

            try
            {
                for (int i = 0; i < count; i++)
                {
                    person[i] = new Person();

                    Console.WriteLine("Enter name {0} :", i);
                    person[i].Name = Console.ReadLine();

                    Console.WriteLine("Enter age {0} :", i);
                    person[i].Age = int.Parse(Console.ReadLine());

                }


                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(person[i].Line);
                }

            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка System.OverflowException!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка System.FormatException!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Press any key to continue..");

            Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int AgeIn4 {
            get
            {
                return Age + 4;
            }
        }

        public string Line
        {
            get
            {
                return $"Name: {Name}, age in 4 years: {AgeIn4}.";
            }
        }
    }
}
