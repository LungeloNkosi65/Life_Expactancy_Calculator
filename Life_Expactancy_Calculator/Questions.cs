using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Expactancy_Calculator.Models
{
    public enum TypeOfQuestion
    {
       PositiveNegative,
       LongQuestion
    }
   public abstract class Questions
    {
        public string Question { get; set; }
        public string  Response { get; set; }
        public int Score { get; set; }
        public TypeOfQuestion TypeQuestion { get; set; }

        public Questions(string question,TypeOfQuestion typeOfQuestion,int score)
        {
            Question = question;
            TypeQuestion = typeOfQuestion;
            Score = score;
        }

        public abstract double ReturnSomething();
    }
}
