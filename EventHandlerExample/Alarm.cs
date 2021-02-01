using System;

namespace EventHandlerExample
{
    public class Alarm
    {

        // public delegate void AlarmRaisedEventHandler(Object source, AlarmEventArgs e);
        // public event AlarmRaisedEventHandler AlarmRaised;

        public event EventHandler<AlarmEventArgs> AlarmRaised;//this does exactly everything the above commented code does but this is more efficient

        public void RaiseAlarm(string colour)
        {
            System.Console.WriteLine("Alert! Alert!");

            OnAlarmRaised(colour);
        }

        protected virtual void OnAlarmRaised(string colour)
        {
            if(AlarmRaised != null)//if alarm raised == null it means there are no subscribers
            {
                AlarmRaised(this, new AlarmEventArgs(){Colour = colour});
            }
        }
    }
    
}