using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservations
{
    public class play : ticket
    {
        public string seat { get; set; }
        public string venue { get; set; }
        public string theater { get; set; }
        public string castInfo { get; set; }
        public string director { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Venue: {0} \n" + 
                "Theater : {1}\n" +
                "Seats: {2}\n" +
                "Director: {3} \n" +
                "Cast: {4)\n",venue,theater,seat,director,castInfo);
        }

        


    }
}
