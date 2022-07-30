using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackLadder
{
    public class Problem
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0;
        public int DieRoll()
        {
            
          Random random = new Random();
          int Roll = random.Next(1,7);
            Console.WriteLine("Die Number is: " + Roll);
            return Roll;
        }
        public void PlayingGame()
        {
            Random random = new Random();
            int CheckPlayer = random.Next(0,3);
            switch(CheckPlayer)
            {
                case 0:
                    this.position += 0;
                    break;
                case 1:
                    this.position -= this.DieRoll();
                    
                    break;
                case 2:
                    this.position+=this.DieRoll();
                    
                    break;

                    

            }
        }
    }
}
