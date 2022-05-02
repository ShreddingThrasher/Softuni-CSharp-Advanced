using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string input;

            while((input = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }

            string partyInput;

            while((partyInput = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(partyInput[0]))
                {
                    vip.Remove(partyInput);
                }
                else
                {
                    regular.Remove(partyInput);
                }
            }

            Console.WriteLine(vip.Count + regular.Count);

            if(vip.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vip));
            }

            if(regular.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, regular));
            }
        }
    }
}
