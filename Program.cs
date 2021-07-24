using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace express_messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string message;
                int repeate, delay, initalDelay;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* THE SOFTWARE IS PROVIDED AS IS WITHOUT ANY WARRANTY OR LIABILITY. \n* THE AUTHOR IS NOT RESPONSIBLE FOR ANY DAMAGES THAT THE PROGRAM MAY CAUSE. \n* USE AT YOUR OWN RISK AND USE YOUR HEAD PEOPLE!!!!");
                Console.WriteLine("***************************************************************************");
                Thread.Sleep(10000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter the message");
                message = Console.ReadLine();
                Console.WriteLine("Specify how many times you want the message to be sent");
                repeate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Specify the delay between the messages in milliseconds");
                delay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Specify the initial delay(after how many seconds the program will start sending the messages)");
                initalDelay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Keyboard.Type(message, repeate, delay, initalDelay));
                Console.ReadKey();
            }
        }
    }
}
