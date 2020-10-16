using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetardedMessages
{
    class Game
    {
        

        static void TheGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(100);
            Console.WriteLine(num);
        } 

    }
}
