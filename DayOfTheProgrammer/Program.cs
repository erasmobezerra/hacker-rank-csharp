namespace DayOfTheProgrammer
{
    class Result
    {
        public static string DayOfProgrammer(int year)
        {
            bool isLeapYear;
            if (year < 1918)
            {
                return (year % 4 == 0) ? $"12.09.{year}" : $"13.09.{year}"; // Calendario Juliano
            }
            else if (year == 1918)
            {
                return "26.09.1918"; // Ano de transição
            }
            else
            {
                isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0 && year % 100 == 0);
                return isLeapYear ? $"12.09.{year}" : $"13.09.{year}"; // Calendario Gregoriano
            }

        }
    }


    class Solution
    {
        public static void Main(string[] args)
        {
            var year = Convert.ToInt32(Console.ReadLine().Trim());
            var result = Result.DayOfProgrammer(year);
            Console.WriteLine(result);
        }
    }

}