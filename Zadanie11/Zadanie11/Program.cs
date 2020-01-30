using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamFileReader();
            var people = reader.ReadPeople("dane.txt");

            var sortePeople = people.OrderBy(x => x.LastName).ThenBy(x => x.Name);

            foreach (var person in sortePeople)
            {
                Console.WriteLine($"{person.Name}\t {person.LastName}");
            }

            Writer writer = new Writer();
            writer.WriteToFile(sortePeople.First(), "result.txt");
            writer.WriteToFileOnlyPhones(sortePeople, "result2.txt");

            writer.WriteToPhone(sortePeople);
            writer.WriteTheLetters(sortePeople);


            Console.Read();
        }
    }
}
