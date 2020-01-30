﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    public class StreamFileReader : IReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            string data;
            using (var reader = new StreamReader(fileName))
            {
                data = reader.ReadToEnd();
            }

            string[] lines = data.Split(
                new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string[] allData = File.ReadAllLines(fileName);

            var people = allData.Select(x =>

                CSVStringToPersonConverter.Convert(x)
            );

            return people.ToList();
        }
    }
}
