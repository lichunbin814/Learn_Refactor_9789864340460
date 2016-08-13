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
            Greeting greeting = new Greeting();
            return greeting.GetGreeting(time, user);
        }
        
    }
}
