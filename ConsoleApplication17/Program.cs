using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fifteens
{
    class Program
    {
        static void Main(string[] args)
        {
            menu.StartTheGame();
            Console.WriteLine("Хотите сыграть еще раз: да/нет ");
            string answer = Convert.ToString(Console.ReadLine());
            while (answer == "да")
            {
                Console.Clear();
                menu.StartTheGame();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

