using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6
{
    class Player
    {
        public string name;
        public int hp;
        public string type;
        public int stamina = 100;


        public Player() { }

        public Player(string n)
        {
            this.name = n;
        }

        public Player(string n, int h)
        {
            this.name = n;
            this.hp = h;
            
        }


        public Player(string n, int h, string t)
        {
            this.name = n;
            this.hp = h;
            this.type = t;
        }    
        
        public void Info()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"{this.name}");
            Console.WriteLine($"{this.hp}");
            Console.WriteLine($"{this.type}");
            Console.WriteLine($"{this.wait}");
            Console.WriteLine("------------------------");
        }

        public void getstamina()
        {
            Console.WriteLine($"Выносливость: {this.stamina}");
        }
        public int attack(Player target)
        {
            this.stamina -= 20;
            target.hp -= 20;

          



            return this.stamina;
        }

        public int wait;


        public int cure()
        {

            this.wait += 20;

            return this.wait;
        }

     







    }
}
