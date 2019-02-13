using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
              int Years = 0;
            
        
            while (initialPopulation <= currentPopulation)
                 initialPopulation += initialPopulation * (int)percent/100 + visitors;
			    Years++;
            return Years;  
            throw new NotImplementedException();
        }
    }
}
