using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (currentPopulation == 0 | initialPopulation == 0)
            {
                throw new ArgumentException();
            }

            double coefficient = percent / 100;
            double population_Now = initialPopulation;
            int years = 0;

            while (population_Now < currentPopulation)
            {
                population_Now += population_Now * coefficient + visitors;
                ++years;
            }
            return years;
        }
    }
}