using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                DateTimeOffset datetime = DateTime.Parse("2020-02-14 12:00:00");
                string message = "Message alarm";
                string phoneNumber = "+7 (495) 123-45-67";
                string chatName = "DotNet Chat";
                string accountName = "Vladislav";

                ReminderItem[] reminderItem = new ReminderItem[3];

                reminderItem[0] = new ReminderItem(datetime, message);
                reminderItem[1] = new PhoneReminderItem(datetime, message, phoneNumber);
                reminderItem[2] = new ChatReminderItem(datetime, message, chatName, accountName);

                for (int i = 0; i < 3; i++)
                {
                    reminderItem[i].WriteProperties();
                    Console.WriteLine();
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
}