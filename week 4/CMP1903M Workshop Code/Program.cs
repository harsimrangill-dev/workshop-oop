using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 4
            //Challenge:  Determine what the value of the accumulator will be when the code is finished running
            //
            //Read each line of the input.
            //Determine whether it is a 'acc' or 'jmp' command for each line
            //Determine the value on each line
            //Find the value of 'acc' at the end
            //HINT: We can read each line as an array (or List) of strings; check [0] for 'a' or 'j', then check [4] and [5] for the values
            //OR: we could split each string at the space into an operation string and a value string
            //Can we read line by line instead of storing in a collection?


            //Week 4
            //Task 1: Add constructors to the Person() class
            //Task 2: create a 'screenName' field within Person
            //Task 3: Create a 'collection' of Person, iterate (i.e. loop) through the collection outputting data for each Person

            

            string[] copy = File.ReadAllLines("text.txt");

            List<string> file = new List<string>(copy);
            int acc = 0;

            for (int i = 0 ; i < copy.Length; i++)
            {
                string init = file[i];
                string initstrs = "";
                for (int j = 0; j < 3 ; j++)
                {
                    initstrs += init[j];
                }
                if (initstrs == "nop")
                    continue;
                else if (initstrs == "jump")
                {
                    if (init[4] == '-')
                    {
                        i -= Convert.ToInt32(init[5]);
                    }
                    else
                    {
                        i += Convert.ToInt32(init[5]);
                    }
                }
                else
                {
                    if (init[4] == '-')
                    {
                        acc -= Convert.ToInt32(init[5]);
                    }
                    else
                    {
                        acc += Convert.ToInt32(init[5]);
                    }
                }
            }
            Console.WriteLine(acc);
        }
    }
}
