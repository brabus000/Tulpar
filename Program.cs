using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Player main = new Player("Player 1",100,"Genghisid");

            
            Console.WriteLine(main);*/

            /*Player man = new Player("Example");
            Player dog = new Player("Zara", 30);
            Player trader = new Player("Steve", 10, "Trade");

            man.Info();
            dog.Info();
            trader.Info();*/

            Player warrior = new Player("Warrior", 100, "Soldier");

            warrior.Info();
            warrior.getstamina();

           

            Player enemy = new Player("Enemy", 30, "Enemies");

            enemy.Info();
            warrior.attack(enemy);
            enemy.Info();

            warrior.cure();


            

            Console.ReadKey();
        }
    }
}
