namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The algorithm in the Readme contains an error
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#

            int difference;
            int startYear;
            int endyear;
            bool validChoice = false;
            do
            {
                Console.WriteLine("Enter a start year");
                startYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an end year");
                endyear = Convert.ToInt32(Console.ReadLine());
                if (startYear >= endyear)
                {
                    Console.WriteLine("Start year must be before end year");
                }
                else if (startYear >= 2000)
                {
                    Console.WriteLine("Start year must be below 2000");
                }
                else
                {
                    validChoice = true;
                }
                
            } while (validChoice != true);

            difference = endyear - startYear;
            Console.WriteLine(difference);



        }
    }
}
