using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Refactor_9789864340460.Sample
{
    public interface IGreeting
    {
        bool IsRight(int hour);

        string GetGreeting();
    }
}
