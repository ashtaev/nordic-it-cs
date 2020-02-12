using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Количество будильников (экземпляров класса)
            int count = 2;

            try
            {
                ReminderItem[] ReminderItem = new ReminderItem[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Введите дату и время будильника №{0} в формате ГГГГ-ММ-ДД ч:м:с", i+1);
                    DateTimeOffset datetime = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Введите сообщение будильника №{0}:", i+1);
                    string message = Console.ReadLine();

                    ReminderItem[i] = new ReminderItem(datetime, message);
                }

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nБудильник №{0}:", i+1);
                    ReminderItem[i].WriteProperties();
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
        }
    }

    class ReminderItem
    {
        // Дата и время будильника
        public DateTimeOffset AlarmDate { get; set; }

        // Сообщение, соответствующее будильнику
        public string AlarmMessage { get; set; }

        // Время до срабатывания будильника. Рассчитываться как текущее время минус AlarmDate
        public TimeSpan TimeToAlarm {
            get {
                return DateTime.Now - AlarmDate;
            }
        }

        // Просрочено ли событие
        public bool IsOutdated {
            get {
                if (TimeToAlarm.Seconds >= 0) return true;
                else return false;
            }
        }

        // Конструктор
        public ReminderItem(DateTimeOffset AlarmDate, string AlarmMessage)
        {
            this.AlarmDate    = AlarmDate;
            this.AlarmMessage = AlarmMessage;
        }

        // Просрочено ли событие
        public void WriteProperties()
        {
            Console.WriteLine("AlarmDate :    {0}", AlarmDate);
            Console.WriteLine("AlarmMessage : {0}", AlarmMessage);
            Console.WriteLine("TimeToAlarm :  {0}", TimeToAlarm);
            Console.WriteLine("IsOutdated :   {0}", IsOutdated);
        }
    }
}