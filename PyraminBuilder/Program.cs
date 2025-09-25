namespace PyraminBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken höjd?");
            int height = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= height; rows++)
            { 
                for (int spaces = 1; spaces <= height - rows; spaces ++)
                {
                    Console.Write(" ");
                
                }
                    for (int stars = 1; stars <= 2 * rows -1 ; stars++)

                    {
                        Console.Write("*");
                    }

                Console.WriteLine();

            }



        }
    }
}
