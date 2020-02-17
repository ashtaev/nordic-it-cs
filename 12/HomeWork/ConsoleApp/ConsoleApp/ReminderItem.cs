using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class ReminderItem
    {
        // Дата и время будильника
        protected DateTimeOffset AlarmDate { get; set; }

        // Сообщение, соответствующее будильнику
        protected string AlarmMessage { get; set; }

        // Время до срабатывания будильника. Рассчитываться как текущее время минус AlarmDate
        protected TimeSpan TimeToAlarm
        {
            get
            {
                return DateTime.Now - AlarmDate;
            }
        }

        // Просрочено ли событие
        protected bool IsOutdated
        {
            get
            {
                if (TimeToAlarm.Seconds >= 0) return true;
                else return false;
            }
        }

        // Конструктор
        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            this.AlarmDate = alarmDate;
            this.AlarmMessage = alarmMessage;
        }

        // Просрочено ли событие
        public virtual void WriteProperties()
        {
            Console.WriteLine("Object type :  {0}", this.GetType());
            Console.WriteLine("AlarmDate :    {0}", AlarmDate);
            Console.WriteLine("AlarmMessage : {0}", AlarmMessage);
            Console.WriteLine("TimeToAlarm :  {0}", TimeToAlarm);
            Console.WriteLine("IsOutdated :   {0}", IsOutdated);
        }
    }
}
