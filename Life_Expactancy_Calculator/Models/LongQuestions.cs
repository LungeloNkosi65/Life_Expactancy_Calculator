using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Expactancy_Calculator.Models
{
    public enum LongOption
    {
        Personal=1,
        LifeStyle=5,
        Nutrition=10,
        Medical=12,
        Family=2
    }
    public class LongQuestions : Questions
    {
        public LongOption LongOptionS { get; set; }
        List<string> AnswerOptions { get; set; }
        public LongQuestions(string question, TypeOfQuestion typeOfQuestion, int score, LongOption longOption) : base(question, typeOfQuestion, score)
        {
            LongOptionS = longOption;
        }
        public override double ReturnSomething()
        {
            return (double)LongOptionS;
        }
    }
}
