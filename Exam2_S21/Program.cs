//Grading ID: R5560
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam2_S21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] states = { "Wisconsin" , "Minnesota", "Utah", "Kentucky", "Maine",

                "Ohio", "California", "Kansas", "Georgia", "Alaska" };

            string[] level = { "High" , "High", "High", "High", "Medium",

                "Medium", "Medium", "Low", "Low", "Low"  };

            string[] manufacturer = { "Pfizer" , "Pfizer", "Moderna", "Pfizer", "Moderna",

                "Pfizer", "Pfizer", "Moderna", "Pfizer", "Pfizer"  };

            string state;
            int i;
            bool found = false;

            Write("Enter name of state: ");
            state = ReadLine();

            i = states.Length - 1;
            while(i >= 0 && !found)
            {
                if (state == states[i])
                    found = true;
                else
                    --i;
            }

            if (found)
                WriteLine("There is a {0} level of vaccine distribution in {1} state. The primary manufacturer is {2}", level[i], states[i], manufacturer[i]);

            else
                WriteLine("Sorry, no data for {0} state.", state);


        }
    }
}
