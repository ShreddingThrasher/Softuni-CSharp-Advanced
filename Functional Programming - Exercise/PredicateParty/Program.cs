using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();

            string input;

            while((input = Console.ReadLine()) != "Party!")
            {
                string[] command = input.Split(' ');

                string operation = command[0];
                string type = command[1];
                string criteria = command[2];

                Predicate<string> predicate = Predicates(type, criteria);

                if(operation == "Remove")
                {
                    names.RemoveAll(predicate);
                }
                else if(operation == "Double")
                {
                    var toAdd = names.FindAll(predicate);

                    int index = names.FindIndex(predicate);
                    
                    if(index >= 0)
                    {
                        names.InsertRange(index, toAdd);
                    }
                }
            }

            if(names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Predicate<string> Predicates(string command, string criteria)
        {
            if(command == "StartsWith")
            {
                return (str) => str.StartsWith(criteria);
            }
            else if(command == "EndsWith")
            {
                return (str) => str.EndsWith(criteria);
            }
            else
            {
                return (str) => str.Length == int.Parse(criteria);
            }
        }
    }
}
