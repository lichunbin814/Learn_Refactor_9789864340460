using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public class MoringGreeting :  IGreeting
    {
        BaseGreeting baseGreeting = new BaseGreeting();

        public string GetGreeting(string user)
        {
            return "早安" + baseGreeting.GetUnReadMailMsg(user);
        }

        public bool IsRight(int hour)
        {
            return hour >= 6 && hour <= 12;
        }
    }
}
