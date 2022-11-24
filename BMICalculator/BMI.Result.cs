using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal partial class BMI
    {
        private static double GetBMI()
        {
            double bodyMassIndex = WeightInKg / (HeightInMeters * HeightInMeters);
            //Console.WriteLine($"Your body mass index is {bodyMassIndex}. See implications below\n");
            return bodyMassIndex;
        }

        public void BMIImplications()
        {
            double value = GetBMI();
            switch (value)
            {
                case <= 18:
                    Console.WriteLine("You are currently underweight. Eat more");
                    break;
                case <= 24.9:
                    Console.WriteLine("Your weight is excellent");
                    break;
                case <= 30:
                    Console.WriteLine("You are overweight. You should watch your weight");
                    break;
                case <= 40:
                    Console.WriteLine("You are currently obese. Please act now");
                    break;
                default:
                    Console.WriteLine("You are severely obesed. Get on a diet asap");
                    break;
            }
        }
    }
}
