using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class ChatReminderItem : ReminderItem
    {
        // Название чата
        private string ChatName { get; set; }

        // Имя аккаунта в чате, которому нужно послать сообщение
        private string AccountName { get; set; }

        public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName, string accountName)
            : base(alarmDate, alarmMessage)
        {
            this.ChatName = ChatName;
            this.AccountName = AccountName;
        }

        public override void WriteProperties()
        {
            Console.WriteLine("Object type :  {0}", this.GetType());
            Console.WriteLine("AlarmDate :    {0}", AlarmDate);
            Console.WriteLine("AlarmMessage : {0}", AlarmMessage);
            Console.WriteLine("TimeToAlarm :  {0}", TimeToAlarm);
            Console.WriteLine("IsOutdated :   {0}", IsOutdated);
            Console.WriteLine("ChatName :     {0}", ChatName);
            Console.WriteLine("AccountName :  {0}", AccountName);
        }
    }
}