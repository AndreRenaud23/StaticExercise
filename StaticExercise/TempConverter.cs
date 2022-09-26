using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {

        public static double FahrenheitToCelsius(double userNumber)
        {
            double userAnswer = (userNumber - 32) * 0.5556;
            return userAnswer;
        }

        public static double CelsiusToFahrenheit(double userNumber2)
        {
            double userAnswer2 = (userNumber2 / 0.5556) + 32;
            return userAnswer2;
        }

    }
}
