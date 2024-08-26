using System;

    class Grade
{
    static void Main( )
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("How many points did you get? (0 - 70)");
            string points = Console.ReadLine();

            try
            {
                int result = Int32.Parse(points);

                switch (result)
                {
                    case <= 19 and >= 0:
                        Console.WriteLine(" Your grade is 0.");
                        break;
                    case <= 29 and >= 20:
                        Console.WriteLine(" Your grade is 1.");
                        break;
                    case <= 39 and >= 30:
                        Console.WriteLine(" Your grade is 2.");
                        break;
                    case <= 49 and >= 40:
                        Console.WriteLine(" Your grade is 3.");
                        break;
                    case <= 59 and >= 50:
                        Console.WriteLine(" Your grade is 4.");
                        break;
                    case <= 70 and >= 60:
                        Console.WriteLine(" Your grade is 5.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse input");
            }
        }

    }

}

