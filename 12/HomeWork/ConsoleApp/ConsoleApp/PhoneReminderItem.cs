using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class PhoneReminderItem : ReminderItem
    {
        //номер телефона, куда нужно послать сообщение
        private string PhoneNumber { get; set; }

        public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber)
            : base(alarmDate, alarmMessage)
        {
            this.PhoneNumber = phoneNumber;
        }

        public override void WriteProperties()
        {
            Console.WriteLine("Object type :  {0}", this.GetType());
            Console.WriteLine("AlarmDate :    {0}", AlarmDate);
            Console.WriteLine("AlarmMessage : {0}", AlarmMessage);
            Console.WriteLine("TimeToAlarm :  {0}", TimeToAlarm);
            Console.WriteLine("IsOutdated :   {0}", IsOutdated);
            Console.WriteLine("PhoneNumber :  {0}", PhoneNumber);
        }
    }
}
