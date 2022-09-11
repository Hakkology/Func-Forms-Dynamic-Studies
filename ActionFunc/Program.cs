using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action (no return value .NET Framework version)

            Action<int, string> action = new Action<int, string>(UserInfo);
            action(3, "Hakkolan");


            //Func (with return value delegate version

            Func <DateTime, double> function = new Func<DateTime, double> (GetUserAgeAtTime);
            double dateDiff = function(new DateTime(1988, 5, 20));
            Console.WriteLine(dateDiff + "days of your life.");
            Console.ReadLine();
        }

        static void UserInfo (int UserId, string fullName)
        {
            Console.WriteLine("User Id : " + UserId);
            Console.WriteLine("Full Name: " + fullName);
        }

        static double GetUserAgeAtTime (DateTime birthdate)
        {
            return (DateTime.Now - birthdate).TotalDays;
        }
    }
}
