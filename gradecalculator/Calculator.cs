using System;

namespace gradecalculator
{
    public class Calculator
    {
        public string GradeCalculator(int score)
        {
            // Score 0-100
            if (score<0 || score > 100)
            {
                return "some thing wrong";
            }
            else if (score>80)
            {
                return "A";
            }
            else if (score>70)
            {
                return "B";
            }
            else if (score>60)
            {
                return "C";
            }
            else if (score>50)
            {
                return "D";
            }
            else if (score>0)
            {
                return "F";
            }
            else
            {
                 return "some thing wrong";
            }          
        }
    }
}
