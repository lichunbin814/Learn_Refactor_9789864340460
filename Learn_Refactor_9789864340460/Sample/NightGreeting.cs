using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public class NightGreeting : BaseGreeting , IGreeting
    {
        public string GetGreeting(string user)
        {
            return "晚安" + GetUnReadMailMsg(user);
        }
      

        public bool IsRight(int hour)
        {
            return hour >= 18;
        }
    }
}
