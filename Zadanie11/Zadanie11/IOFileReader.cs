using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    public class IOFileReader : IReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            string[] allData = File.ReadAllLines(fileName);

            var people = allData.Select(x => CSVStringToPersonConverter.Convert(x));



            return people.ToList();
        }
    }
}
