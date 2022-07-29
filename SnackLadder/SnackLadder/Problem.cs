using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackLadder
{
    public class Problem
    {
        
        public int DieRoll()
        {
            
          Random random = new Random();
          int Roll = random.Next(1,7);
            return Roll;
        }
    }
}
