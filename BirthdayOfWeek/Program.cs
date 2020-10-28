using System;

namespace BirthdayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            calculation();
        }

        public static void calculation()
        {
            Console.WriteLine("What year were you born?");
            int yearOfBirth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born?");
            int monthOfBirth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What day were you born?");
            int dayOfBirth = Int32.Parse(Console.ReadLine());
            DateTime weekOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            var week = weekOfBirth.DayOfWeek;
            Console.WriteLine(week);
        }

    }
}
