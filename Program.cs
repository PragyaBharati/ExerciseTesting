using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitTest
{
    class Program
    {
        public static List<Player> Player()
        {
            List<Player> Playerlist = new List<Player>
            {
            new Player{ PId=1,PName = "Sam",PTeam = "India"},
             new Player{ PId=2,PName = "Sameer",PTeam = "India"},
              new Player{ PId=3,PName = "Rohit",PTeam = "India"}

            };
            return Playerlist;
            }

    static void Main(string[] args)
        {
        }
          
    }
}
