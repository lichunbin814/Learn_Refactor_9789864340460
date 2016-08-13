using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public class HelloWorld
    {
        public string sayHello(DateTime time, string user)
        {
            int hour = time.Hour;
            string greeting = "";
            if (hour >= 6 && hour <= 12)
            {
                greeting = "早安";
            }
            else if (hour >= 12 && hour <= 17)
            {
                greeting = "午安";
            }
            else
            {
                greeting = "晚安";
            }

            return string.Format("Hi, {0}. {1}", user, greeting);
        }
    }
}
