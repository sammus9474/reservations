using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            play play = new play();
            play.eventName = "A Midnight Summers Dream";
            play.eventTime = "6 Pm, Tuesday June 2 2020";
            play.ticketAmmo = 19.99M;
        }
    }
}
