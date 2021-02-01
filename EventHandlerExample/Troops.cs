using System;

namespace EventHandlerExample
{
    public class Troops
    {
        public void OnAlarmRaised(object sender, AlarmEventArgs e)
        {
            CallTroops();
        }
        
        public void CallTroops()
        {
            System.Console.WriteLine("Troops called...");
        }
        
    }
    
}