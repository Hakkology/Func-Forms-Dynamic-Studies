using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.DynamicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dynamic a = 5;
            //Console.WriteLine(a);
            //a = "AA";
            //Console.WriteLine(a);

            //dynamic human = new ExpandoObject();
            //human.Name = "Hakan";
            //human.LastName = "Yıldız";
            //Console.WriteLine(human.Name + " " + human.LastName);

            //dynamic person = new ExpandoObject();
            //person.Name = "Hakan";
            //person.LastName = "Yıldız";
            //person.ShowName = new Action(() =>
            //{
            //    Console.WriteLine("Name: " + person.Name);
            //});

            //person.Repeat = new Func<string, string>(gelen =>
            //{
            //    return gelen;
            //});

            //person.ShowName();
            //dynamic result = person.Repeat("Multiple Repeat");
            //Console.WriteLine("Result is: " + result);

            foreach (dynamic user in GetList())
            {
                Console.WriteLine("{0} {1}", user.Name, user.Surname);
            }

            Console.ReadLine();
        }
        private static IEnumerable<dynamic> GetList()
        {
            var users = new List<User>
            {
                new User() { ID = 1, FirstName = "Hakan", LastName = "Yıldız"},
                new User() { ID = 2, FirstName = "Manolya Müjgan", LastName = "Gürbüz"}
            };
            return from k in users
                   select new { Name = k.FirstName, Surname= k.LastName };
        }
    }

    class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
