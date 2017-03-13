using System;
using System.Collections.Generic;
namespace MaximumValue
{
    public class WeightCapacity
    {
        public List<Cakes> Cakes { get; set; }
        public int Capacity { get; set; }
        public WeightCapacity()
        {
            Cakes = new List<Cakes>();
        }
        public int GetMaxValByCapacity()
        {
            int maxVal = 0;
            int[] maxValues = new int[Capacity + 1];
            //Loop for Capacity
            for(var weight = 1; weight <= Capacity; weight++)
            {
                //Loop for Values
                for (int y = 0; y < Cakes.Count; y++)
                {
                    if (weight >= Cakes[y].Weight)
                    {
                        var sampleValue = maxValues[weight - Cakes[y].Weight] + Cakes[y].Value;
                        maxVal = Math.Max(sampleValue, maxVal);
                    }
                }
                maxValues[weight] = maxVal;
            }
            
            return maxValues[Capacity];
        }
    }

    public class Cakes
    {
        public int Weight { get; set; }
        public int Value { get; set; }
    }
}


