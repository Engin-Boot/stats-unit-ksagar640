using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
    	Stats readings = new Stats();
        public Stats CalculateStatistics(List<double> numbers) {
            readings.min = StatsUtility.CalculateMinimum(numbers);
            readings.max = StatsUtility.CalculateMaximum(numbers);
            readings.average = StatsUtility.CalculateAverage(numbers);
            return readings;
        }
       public double getMin(){
       	return readings.min;
       }
       public double getMax(){
       	return readings.max;
       }
       public double getAvg(){
       	return readings.average;
       }
    }
}
