namespace TestTask1
{
    internal class Check
    {
        public static double CheckNegativeNumeric(double numeric)
        {
            if (numeric < 0)
            {
                Console.WriteLine($"Число должно быть {numeric} неотрицательным.");
                Environment.Exit(0);
                return 0;
            }
            else
            { 
                return numeric; 
            }
        }
    }
}
