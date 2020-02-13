using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Expactancy_Calculator.Models
{
   public class Calculator
    {
        public List<Questions> QustionsList { get; set; }
        public List<AgeBracket> AgeBrackets { get; set; }
        public double CurrentExpected { get; set; }
        public Calculator()
        {
            QustionsList = new List<Questions>()
            {
               
                new ShortQuestions("Do you smoke \n(1)Positive \n(0)Negetive",TypeOfQuestion.PositiveNegative,10,ShortOption.Smoke),
                new ShortQuestions("Do you drink \n(1)Positive \n(0)Negetive",TypeOfQuestion.PositiveNegative,10,ShortOption.Drink),
                new ShortQuestions("Do you excercise \n(1)Positive \n(0)Negetive",TypeOfQuestion.PositiveNegative,10,ShortOption.Exercise),
                new ShortQuestions("Do you take any drungs \n(1)Positive \n(0)Negetive",TypeOfQuestion.PositiveNegative,10,ShortOption.Drugs),

                new LongQuestions("How is your blood pressure?"+"\n(1)Normal \n(2)Medicated \n(3)High",TypeOfQuestion.LongQuestion,5,LongOption.Medical),
                new LongQuestions("How Often do you exercise \n(1)Daily\n(2)Weekly\n(3)I dont",TypeOfQuestion.LongQuestion,5,LongOption.Medical),
                new LongQuestions("How many driving violations have you recieved\n(1)None\n(2)1 Violation\n(3)1 + violations",TypeOfQuestion.LongQuestion,5,LongOption.Medical),
            };
            AgeBrackets = new List<AgeBracket>()
            {
                new AgeBracket(1,16,75,"M"),
                new AgeBracket(16,21,65,"F"),
                new AgeBracket(21,40,50,"M"),
            };
        }
      
        public void Start()
        {
            string input = " ";
            string gender = "";
            Console.WriteLine("How old are you ");
            input = Console.ReadLine();
            if (input.All(Char.IsDigit) && int.Parse(input)!=0 && double.Parse(input)>0)
            {
                Console.WriteLine("Select gender from the following (M)Male (F)Female");
                gender = Console.ReadLine().ToUpper();

                if (String.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Select gender from the following (M)Male (F)Female");
                    gender = Console.ReadLine();
                }
               
                    foreach (var item in AgeBrackets)
                    {
                        if (double.Parse(input) >= item.LowerValue && double.Parse(input) < item.UperValue && gender == item.Gender)
                        {
                            CurrentExpected = item.ExpectedYears;
                            Console.WriteLine("*************************************** Current life expectancy " + CurrentExpected +" years****************************************************");
                        break;
                        }
                    }
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
            DisplayQuestions(double.Parse(input));

        }






        public void DisplayQuestions(double age)
        {
            string input = " ";
            foreach (var item in QustionsList)
            {
                if (item.TypeQuestion == TypeOfQuestion.PositiveNegative)
                {
                    Console.WriteLine(item.Question);
                    input = Console.ReadLine().ToUpper();
                    if (int.Parse(input) == 1)
                    {
                        CurrentExpected -= item.ReturnSomething();
                    }
                }
                //if (item. TypeQuestion == TypeOfQuestion.LongQuestion)
                //{
                //    Console.WriteLine(item.Question);
                //    input = Console.ReadLine().ToUpper();
                //}

            }
            if (CurrentExpected < age)
            {
                CurrentExpected = age;
            }
            Console.WriteLine("*******************************New Life expectancy " + CurrentExpected + "Years*******************************");
        }

    }
}
