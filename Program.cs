using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using express_messenger.DataModels;

namespace express_messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageData messageData = new MessageData();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* THE SOFTWARE IS PROVIDED AS IS WITHOUT ANY WARRANTY OR LIABILITY. \n* THE AUTHOR IS NOT RESPONSIBLE FOR ANY DAMAGES THAT THE PROGRAM MAY CAUSE. \n* USE AT YOUR OWN RISK AND USE YOUR HEAD PEOPLE!!!!\n");
            Console.WriteLine("***************************************************************************");
                
            Thread.Sleep(10000);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("What's the message you want sent? ");
            messageData.Message = Console.ReadLine();

            Console.Write("How many times do you want it sent? ");
            messageData.Repeat = int.Parse(Console.ReadLine());

            Console.Write("How many seconds should the delay in between each message be? ");
            messageData.Delay = int.Parse(Console.ReadLine());

            Console.Write("How many seconds should the first message delay be? ");
            messageData.InitialDelay = int.Parse(Console.ReadLine());

            try
            {
                Keyboard.Send(messageData);
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                return;
            }

            Console.ReadKey();
        }
    }
}
