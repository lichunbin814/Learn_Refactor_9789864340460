using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    

    public class AfternoonGreeting : BaseGreeting , IGreeting
    {
        BaseGreeting baseGreeting = new BaseGreeting();

        public string GetGreeting(string user)
        {
            return "午安" + baseGreeting.GetUnReadMailMsg(user);
        }


     

        public bool IsRight(int hour)
        {
            return hour >= 12 && hour <= 17;
        }
    }
}
