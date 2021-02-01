using System;

namespace EventHandlerExample
{
    public class AlarmDetailSender
    {
        public void OnAlarmRaised(object sender, AlarmEventArgs e)
        {
            Console.WriteLine($"sending out {e.Colour} alert..");
        }
    }
    
}