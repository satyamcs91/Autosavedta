using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosavedata
{
    class Program
    {
        static void Main(string[] args)
        {   
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(15);
            var timer = new System.Threading.Timer((e) =>
            {
                Random rnd = new Random();
                long num = rnd.Next();
                var dend = new Sendnumber();
                dend.SavenumberAuto(num);
            }, null, startTimeSpan, periodTimeSpan);

            Console.Read();
           
        }
    }
}
