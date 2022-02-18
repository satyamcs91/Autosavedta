using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosavedata
{
  public class Sendnumber
    {
        public void SavenumberAuto(long number)
        {
            using (DashboardProgEntities dashboard = new DashboardProgEntities())
            {
                var num = new Number()
                {
                    Number1 = number
                };
                dashboard.Numbers.Add(num);
                dashboard.SaveChanges();
            }
        }

    }
}
