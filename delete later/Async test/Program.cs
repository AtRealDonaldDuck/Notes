using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_test
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMessaged();

            Console.WriteLine("EoF");

            while (true) ;
        }

        public static async Task DelayedMessageAsync()
        {
            await Task.Run(() => Thread.Sleep(10));
            Console.WriteLine("waited 1000 millisecondos");
        }

        public static void Message()
        {
            Console.WriteLine("didnt wait for shit");
        }

        public static async void SendMessaged()
        {
            Console.WriteLine("Called Send Message");
            DelayedMessageAsync();

            Message();
        }
    }
}
