using System;

class FinancialForecast
{

    static void Main()
    {
        double initialValue = 10000;
        double growthRate = 0.05;
        int years = 10;

        double futureValue = PredictFutureValue(initialValue, growthRate, years);
        Console.WriteLine($"Predicted value after {years} years: {futureValue:C2}");
    }


    static double PredictFutureValue(double currentValue, double rate, int years)
    {
        if (years == 0)
            return currentValue;
        return PredictFutureValue(currentValue * (1 + rate), rate, years - 1);
    }
}