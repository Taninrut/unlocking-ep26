using System;

namespace gradecalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Input your score : ");
            var input = Console.ReadLine();

            if (Int32.TryParse(input,out int score))
            {
              Calculator cal = new Calculator();
              var grade = cal.GradeCalculator(score);
              Console.Write("Congratulation  : ");
              Console.Write(grade);
            } 
            else    
            {
                Console.Write("Input Error");
            }
         
        }
    }
}
