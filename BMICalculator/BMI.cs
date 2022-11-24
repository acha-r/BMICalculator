namespace BMICalculator
{
    internal partial class BMI
    {
        //weight in kg
        //height in meters

        public static double WeightInKg { get; set; }
        public static double HeightInMeters { get; set; }

        public static void GetWeightInKg()
        {
            try
            {
            weight:
                Console.WriteLine("Enter your weightin kg below");
                WeightInKg = double.Parse(Console.ReadLine());
                if (WeightInKg < 4)
                {
                    Console.WriteLine("Weight cannot be less than 4kg");
                    goto weight;
                }

            height:
                Console.WriteLine("\nEnter your height in meters below");
                HeightInMeters = double.Parse(Console.ReadLine());
                if (HeightInMeters < 0)
                {
                    Console.WriteLine("Height cannot be less than 0 meters");
                    goto height;
                }

            }
            catch (FormatException e)
            {
                throw new InvalidDetailsException("", e);
                Console.WriteLine(e.Message);
                Console.WriteLine("Start again");
                GetWeightInKg();
            }
        }
        public BMI()
        {
            try
            {
                GetWeightInKg();
            }
            catch (InvalidDetailsException ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }

}
