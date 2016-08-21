using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public class Greeting
    {
        /// <summary>
        /// 取得問候語
        /// </summary>
        private string GetGreeting(int hour, string user)
        {
            //將早、中、晚的方法移至不同的方法內，並定義要做的事情（IGreeting）
            IGreeting[] greetingRules = new IGreeting[]
            {
                new MoringGreeting(),
                new AfternoonGreeting(),
                new NightGreeting()
            };

            foreach (IGreeting greetingRule in greetingRules)
            {
                if (greetingRule.IsRight(hour))
                {
                    return greetingRule.GetGreeting(user);
                }
            }

            throw new Exception("無法取得問候語");
        }

        /// <summary>
        /// 取得問候語
        /// </summary>
        public string GetGreeting(DateTime time, string user)
        {
            int hour = time.Hour;
            string greeting = GetGreeting(hour, user);

            return string.Format("Hi, {0}. {1}", user, greeting);
        }
    }
}
