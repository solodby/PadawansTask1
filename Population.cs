using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
           if (initialPopulation <=0 || currentPopulation <= 0 )
            { return 0; }
        
            int Years = 0;
            
        
            while (initialPopulation <= currentPopulation)
                 initialPopulation += initialPopulation * (int)percent/100 + visitors;
			    Years++;
            return Years;     
          
           
        }
    }
}
