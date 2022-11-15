using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numOfProjects = int.Parse(Console.ReadLine());
            int timeForProject = 3;
            int hoursNeeded = numOfProjects * timeForProject;
            Console.WriteLine($"The architect {name} will need {hoursNeeded} hours to complete {numOfProjects} project/s.");
        }
    }
}
