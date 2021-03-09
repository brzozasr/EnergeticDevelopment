using System;
using System.Threading;
using EnergeticDevelopment.Simulation;

namespace EnergeticDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            while (i < 366)
            {
                Console.Clear();
                Console.WriteLine($"Day(s): {i}");
                var simulation = new Simulator();
                simulation.RunSimulation();

                i++;
                Thread.Sleep(1000);
            }
        }
    }
}