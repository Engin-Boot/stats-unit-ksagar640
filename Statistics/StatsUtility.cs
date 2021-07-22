using System;
using System.Collections.Generic;

namespace Statistics
{
    public static class StatsUtility
    {
    	public static double CalculateMinimum(List<double> numbers)
    	{
    		if (numbers.Count == 0) return Double.NaN;
    		double min = float.MaxValue;
    		foreach (double number in numbers)
    		{
    			if (min > number) min = number;
    		}
    		return min;
    	}
    	public static double CalculateMaximum(List<double> numbers)
    	{
    		if (numbers.Count == 0) return Double.NaN;
    		double max = float.MinValue;
    		foreach (double number in numbers)
    		{
    			if (max < number) max = number;
    		}
    		return max;
    	}
    	public static double CalculateAverage(List<double> numbers)
    	{
    		if (numbers.Count == 0) return Double.NaN;
    		double sum = 0.0;
    		foreach (double number in numbers)
    		{
    			sum += number;
    		}
    		double average = sum / numbers.Count;
    		return average;
    	}

    }
}