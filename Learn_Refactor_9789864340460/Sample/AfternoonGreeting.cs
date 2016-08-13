using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public class AfternoonGreeting : IGreeting
    {
        public string GetGreeting()
        {
            return "午安";
        }

        public bool IsRight(int hour)
        {
            return hour >= 12 && hour <= 17;
        }
    }
}
