using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservations
{
    public abstract class ticket
    {

        public string eventTime { set; get; }
        public string eventDisc { set; get; }
        public string eventName { set; get; }
        public decimal ticketAmmo { set; get; }
        public string custName { set; get; }
        public string custCont { set; get; }

        public override string ToString()
        {
            return string.Format("customer Name : {0} \n" + 
                "Phone: {1}\n"  +
                "Event : {2}\n" +
                "Discription : {3}\n" +
                "Event Dates : {4}\n" +
                "Ammount of ticker : {5}\n\n" +,custName,custCont,eventName,eventDisc,eventTime,ticketAmmo)
                
        }


    }
}
