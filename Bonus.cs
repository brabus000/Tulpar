using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6
{
    class Bonus
    {
      
        
        public int wait;
        

        public Bonus() { }

       
        public Bonus(int w)
        {
           
            this.wait = w;
        }


        public int cure()
        {
            
            this.wait += 20;

            return this.wait;
        }


    }
}
