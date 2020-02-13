using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Expactancy_Calculator.Models
{
   public class AgeBracket
    {
        public double LowerValue { get; set; }
        public double UperValue { get; set; }
        public double ExpectedYears { get; set; }
        public string Gender { get; set; }

        public AgeBracket(double lowerValue,double uperValue,double year,string gender)
        {
            LowerValue = lowerValue;
            UperValue = uperValue;
            ExpectedYears = year;
            Gender = gender;
        }
    }
}
