using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public class NightGreeting : BaseGreeting , IGreeting
    {
        protected override string GetGreeting()
        {
            return "晚安";
        }
      

        public bool IsRight(int hour)
        {
            return hour >= 18;
        }
    }
}
