using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // add al names
            List<string> names = new List<string> { "Will R", "Will D", "Ethan", "Tom", "Henry", "Adam", "Ben", "Mr Dring", "Cormac", "Ashton"};

            // add scores in order of names
            List<int> Score = new List<int> {508, 391, 155, 243, 344, 358, 212, 600, 374, 348};

            Console.WriteLine(names[3]);
        }
    }
}
