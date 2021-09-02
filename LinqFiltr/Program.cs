using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFiltr
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = GetPeoples(20).ToList();
            var filtr = from item in people 
                        orderby item.Age
                        orderby item.Email
                        orderby item.Surename
                        orderby item.Name
                        select item;

            foreach (var item in filtr)
            {
                Console.WriteLine(item);
            }


        }

        static IEnumerable<People> GetPeoples(int count)
        {
            string[] name = new string[]
            {
                "Aram","Albert","Mari","Mariam","Ashot","Hakob","Hrach","Ani","Gohar"
            };

            string[] surename = new string[]
            {
                "Hakobyan","Hovhanisyan","Vardanyan","Adamyan","Abrahamyan","Matevosyan"
            };

            string[] email = new string[]
            {
                "@gmail.com","@yandex.ru","@outlook.com","@mail.ru","@yahoo.com"
            };
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                var indexname = rand.Next(0, name.Length);
                var indexsure = rand.Next(0, surename.Length);
                var indexemail = rand.Next(0, email.Length);
                var indexage = rand.Next(18, 68);

                var people =  new People(name[indexname], surename[indexsure], name[indexname] + indexage + email[indexemail], indexage);
                yield return people;
            }
        }
    }
}
