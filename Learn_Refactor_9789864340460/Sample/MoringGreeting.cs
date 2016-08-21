using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public class MoringGreeting : IGreeting
    {
        public string GetGreeting(string user)
        {
            if (user == "王小明")
            {
                return "早安，" + GetUnReadMailMsg(user);
            }
            else if (user == "陳大華")
            {
                return "早安，" + GetUnReadMailMsg(user);
            }
            else
            {
                return "早安";
            }
        }


        /// <summary>
        /// 取得未讀Mail的提示
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private string GetUnReadMailMsg(string user)
        {
            int unReadMailCount = GetUnReadMailCount(user);
            return unReadMailCount == 0 ? "" : string.Format("您有{0}封未讀Mail", unReadMailCount);
        }

        /// <summary>
        /// 取得未讀Mail的數量
        /// </summary>        
        private int GetUnReadMailCount(string user)
        {
            //此例省略跟外部資料介接的過程直接回傳特定的數量示意（實務上大多會使用資料庫）
            if (user == "王小明")
            {
                return 999;
            }
            else if (user == "陳大華")
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        public bool IsRight(int hour)
        {
            return hour >= 6 && hour <= 12;
        }
    }
}
