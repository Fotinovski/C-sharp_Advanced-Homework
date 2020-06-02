using System;

namespace Exam02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Second Task

            Console.WriteLine("Chek the date in this format(MM/DD/YYYY)");
            string inputDate = Console.ReadLine();
            DateTime date = DateTime.Parse(inputDate);
            bool isLeapYear = DateTime.IsLeapYear(date.Year);

            while (true)
            {
                if (isLeapYear && (date.Month == 2) && (date.Day >= 29))
                {
                    Console.WriteLine($"The date you entered {date} does not exist");
                    break;
                }


                if ((date.Month == 1 && date.Day == 1) || (date.Month == 1 && date.Day == 7) ||
                    (date.Month == 3 && date.Day == 20) || (date.Month == 5 && date.Day == 1) ||
                    (date.Month == 8 && date.Day == 3) || (date.Month == 9 && date.Day == 8) ||
                    (date.Month == 10 && date.Day == 12) || (date.Month == 10 && date.Day == 23) ||
                    (date.Month == 12 && date.Day == 8))
                {
                    Console.WriteLine($"This day is {date.DayOfWeek}, and its holiday");
                    break;
                }
                else if (date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday)
                {
                    Console.WriteLine($"This day is  {date.DayOfWeek} and is working day");
                    break;
                }
                else
                {
                    Console.WriteLine($"It's {date.DayOfWeek}, its weekend and its not working day");
                    break;
                }
            }


            #endregion
        }
    }
}
