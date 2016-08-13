using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public class MoringGreeting : IGreeting
    {
        public string GetGreeting()
        {
            return "早安";
        }

        public bool IsRight(int hour)
        {
            return hour >= 6 && hour <= 12;
        }
    }
}
