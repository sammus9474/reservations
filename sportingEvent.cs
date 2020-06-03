using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservations
{
    public class sportingEvent : ticket
    {
        public string arena { get; set; }
        public string portalAndSeat { get; set; }
        public string teams { get; set; }
        public string coaches { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Arena: {0} \n"+
                "Seating: {1} \n"+
                "teams playing: {2} \n" +
                "coaches: {3} \n",arena,portalAndSeat,teams,coaches);
        }



    }
}
