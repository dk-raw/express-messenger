using express_messenger.DataModels;
using System;
using System.Threading;
using System.Windows.Forms;

namespace express_messenger
{
    static class Keyboard
    {
        public static void Send(MessageData data) 
        {
            if (!data.Valid)
                throw new Exception("Message data was invalid.");
            
            Console.WriteLine($"Keypresses will start firing in {data.InitialDelay} seconds.");
            Thread.Sleep(data.InitialDelay * 1000);

            DateTime startTime;
            
            Console.ForegroundColor = ConsoleColor.Green;
            for (int x = 1; x <= data.Repeat; x++)
            {
                startTime = DateTime.Now;
                Thread.Sleep(data.Delay);

                SendKeys.SendWait(data.Message);
                SendKeys.SendWait("{Enter}");

                if (x == 1)
                    Console.WriteLine($"Message sent successfully 1 time in {DateTime.Now.Subtract(startTime).TotalMilliseconds}ms");
                else
                    Console.WriteLine($"Message sent successfully {x} times in {DateTime.Now.Subtract(startTime).TotalMilliseconds}ms");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
