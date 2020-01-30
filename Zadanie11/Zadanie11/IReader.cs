using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    public interface IReader
    {
        List<Person> ReadPeople(string fileName);
    }
}
