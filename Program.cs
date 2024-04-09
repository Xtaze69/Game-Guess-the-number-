using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра__Угадай_число_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diapazon;
            Console.WriteLine("Введите максимальное число диапазона: ");
            diapazon = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int numberii = rand.Next(0, diapazon + 1);
            int usernumber;
            string endGame;

            Console.WriteLine("Введите число, если вы хотите закончить игру нажмите Enter.");

            while (true)
            {
                endGame = Console.ReadLine();
                if (endGame == string.Empty)
                {
                    Console.WriteLine($"Игра завершена. {numberii} - загаданное число.");
                    break;
                }

                usernumber = int.Parse(endGame);
                if (usernumber > numberii)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуйте еще раз.");
                }
                else if (usernumber < numberii)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще раз.");
                }
                else
                {
                    Console.WriteLine("Поздравляю, вы угадали число!");
                }
            }
            Console.ReadKey();
        }
    }
}
