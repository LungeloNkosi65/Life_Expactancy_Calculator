using Life_Expactancy_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Expactancy_Calculator
{
   public class BracketLogic
    {
        public List<AgeBracket> AgeBrackets { get; set; }

        public BracketLogic()
        {
            AgeBrackets = new List<AgeBracket>()
            {
                new AgeBracket(1,16,75,"M"),
                new AgeBracket(16,21,65,"F"),
                new AgeBracket(21,40,50,"M"),
            };
        }

        public double AgeFallIn(double age, string gender)
        {
            foreach (var item in AgeBrackets)
            {
                if (age >= item.LowerValue && age < item.UperValue && gender == item.Gender)
                {
                    return item.ExpectedYears;
                }
            }
            return 0;
        }

    }
}
