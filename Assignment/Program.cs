namespace Assignment
{
    internal class Program
    {
        #region Q1
        static double GetDistance(Point P01, Point P02)
        {
            double Result = Math.Sqrt((Math.Pow((P02.X - P01.X), 2)) + (Math.Pow((P02.Y - P01.Y), 2)));
            return Result;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates
            //the distance between them.
            Point P01;
            Point P02;

            Console.WriteLine("Enter X1");
            P01.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1");
            P01.Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2");
            P02.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2");
            P02.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Distance Btw This two point Is {GetDistance(P01, P02)}");
            #endregion


        }
    }
}
