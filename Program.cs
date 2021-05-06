using System;
using System.Collections.Generic;
using System.Linq;

namespace Challange1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollexa;
            int ra;
            double avg;
            double sum;
            ra = 0;
            int rollnum;
            rollnum = 0;


            List<int> rollhist = new List<int>();


            while (ra == 0)
            {
                //Random number generator
                Random r = new Random();
                int genRand = r.Next(1, 6);
                rollhist.Add(genRand);
                rollnum++;
                Console.WriteLine("Rolling dice...");
                Console.WriteLine("The number was : " + genRand);
                Console.WriteLine("Type '0' to roll again or '1' to stop");

                ra = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ok stopping. How many rolls do you want to examine?");
            rollexa = int.Parse(Console.ReadLine());

            while (rollexa > rollnum)
            {
                Console.WriteLine(rollexa + " Is higher then the number of rolls");
                Console.WriteLine("How many rolls do you want to examine?");
                rollexa = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("The Average of the first " + rollexa + " rolls is:");

            var NewList = rollhist.Skip(0).Take(rollexa);

            //calc avg
            avg = NewList.Average();
            Convert.ToInt32(avg);
            Console.WriteLine(avg);

            Console.WriteLine("The Sum of the first " + rollexa + " rolls is:");

            //calc sum
            sum = NewList.Sum();
            Convert.ToInt32(sum);
            Console.WriteLine(sum);

            Console.WriteLine("Here is a list of all the rolls:");

            foreach (int i in rollhist)
            {
                Console.Write(i + ",");
            }


        }
    }
}
