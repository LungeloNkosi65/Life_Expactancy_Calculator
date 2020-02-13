using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Expactancy_Calculator.Models
{
    public enum ShortOption
    {
        Smoke=10,
        Drink=5,
        Exercise=3,
        Drugs=12
    }
   public class ShortQuestions:Questions
    {
        public ShortOption ShortOptions { get; set; }
        public ShortQuestions(string question, TypeOfQuestion typeOfQuestion,int score,ShortOption shortOption) : base(question, typeOfQuestion,score)
        {
            ShortOptions = shortOption;
        }

        public override double ReturnSomething()
        {
            return (double)ShortOptions;
        }
    }
}
