using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fifteens
{
    class menu
    {
        static public void StartTheGame()
        {
            Random gen = new Random();
            
            Console.WriteLine("Введите число, размер поля");
            string s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            game player = new game(number);
            player.Fillig(gen);
            Console.Clear();
            while (!player.CheckingSequence())
            {
                player.Printing();
                Console.WriteLine("Выберете число,которое хотите передвинуть");
                int value = Convert.ToInt16(Console.ReadLine());
                player.Shift(value);
                Console.Clear();

            }
            player.Printing();
            Console.WriteLine("Вы выиграли");
        }
    }
}