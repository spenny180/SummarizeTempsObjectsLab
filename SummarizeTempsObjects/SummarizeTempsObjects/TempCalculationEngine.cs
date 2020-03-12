using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumOfTemps = 0;
            foreach (int temp in _temperatures)
                sumOfTemps += temp;
            int averageTemps = sumOfTemps / _temperatures.Count;

            return averageTemps; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {

            // add logic to calculate temps above the threshold
            int TempsAboveThreshold = 0;
            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    TempsAboveThreshold++;
                }
            }
            return TempsAboveThreshold; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int TempsBelowThreshold = 0;
            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    TempsBelowThreshold++;
                }
            }
            return TempsBelowThreshold; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int TempsAtThreshold = 0;
            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    TempsAtThreshold++;
                }
            }
            return TempsAtThreshold; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
