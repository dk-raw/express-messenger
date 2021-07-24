using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace express_messenger
{
    class Keyboard
    {
        public static string Type(string message, int repeate, int delay, int initialDelay)
        {
            if (message == null || message == "" || repeate == null || repeate == 0 || delay == null || delay == 0 || initialDelay == null || initialDelay == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "An error occured, try again";
            }
            else
            {
                Console.WriteLine($"Keypresses will start firing in {initialDelay}s");
                Thread.Sleep(initialDelay * 1000);
                DateTime start = DateTime.UtcNow;
                for (int i = 0; i < repeate; i++)
                {
                    if (i != repeate - 1)
                    {

                        Thread.Sleep(delay);
                        SendKeys.SendWait(message);
                        SendKeys.SendWait("{Enter}");
                        if (i == 0)
                        {
                            Console.WriteLine($"Sent {i + 1} time");
                        }
                        else
                        {
                            Console.WriteLine($"Sent {i + 1} times");
                        }
                    }
                    else
                    {
                        Thread.Sleep(delay);
                        SendKeys.SendWait(message);
                        SendKeys.SendWait("{Enter}");
                        if (i == 0)
                        {
                            Console.WriteLine($"Sent {i + 1} time");
                        }
                        else
                        {
                            Console.WriteLine($"Sent {i + 1} times");
                        }
                    }
                }
                if (repeate == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    return $"Message sent successfully {repeate} time in {Convert.ToInt32((DateTime.UtcNow - start).TotalMilliseconds)}ms";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    return $"Message sent successfully {repeate} times in {Convert.ToInt32((DateTime.UtcNow - start).TotalMilliseconds)}ms = Press Enter to conntinue";
                }
            }
        }
    }
}
