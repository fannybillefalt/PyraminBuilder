namespace PyraminBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken höjd?");
            int height = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= height; rows++) //Outer loop, runs once per row, begins with one up to last row. 
            { 
                for (int spaces = 1; spaces <= height - rows; spaces ++) //First inner loop, the number of spaces is the height minus the rows,
                                                                         //further down, less spaces.
                {
                    Console.Write(" ");
                
                }
                    for (int stars = 1; stars <= 2 * rows -1 ; stars++)//Second inner loop, needs minus 1 per row to match how many stars.

                    {
                        Console.Write("*");
                    }

                Console.WriteLine();//Changing to new row.

            }



        }
    }
}
