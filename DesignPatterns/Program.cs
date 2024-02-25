using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo =  new Repository();

           // repo.AddDepartment("IT");

           // repo.AddEmployee();

            repo.AddBoth();




            //// use of sorted list.
            //Dictionary<int, string> keyValues = new Dictionary<int, string>();

            //keyValues.Add(3, "Arpit");
            //// keyValues.Add(1, "arpit"); // same key already exists, Error runtime.
            //keyValues.Add(2, "Arpit"); // succeed value can be same in key value pair.
            //// difference between dictionry and sortedList is sorted list return result in sort order, dictionry will not.
            //var str = keyValues.ContainsKey(3);
        }
    }
}
