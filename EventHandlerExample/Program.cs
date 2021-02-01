using System.Threading;

namespace EventHandlerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var alarm = new Alarm();//publisher
            var troops = new Troops();//subscriber
            var alarmDetailSender = new AlarmDetailSender();//subscriber

            alarm.AlarmRaised += troops.OnAlarmRaised;//subscribes troops to alarm 
            alarm.AlarmRaised += alarmDetailSender.OnAlarmRaised;//subscribes alarm detail sender to alarm


            alarm.RaiseAlarm("Red");

            System.Console.WriteLine("done");

            while(true) Thread.Sleep(5000);//just here so terminal doesnt close on completion

            
        }
    }
}
