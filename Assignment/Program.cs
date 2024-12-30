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

        #region MyRegion
        static Person GetOldestPerson(Person P01, Person P02, Person P03)
        {
            Person Oldest = default;
            if (P01.Age >= P02.Age)
            {
                if (P01.Age >= P03.Age)
                {
                    Oldest = P01;
                }
            }
            else if (P02.Age >= P01.Age)
            {
                if (P02.Age >= P03.Age)
                {
                    Oldest = P02;
                }
            }
            else
            {
                Oldest = P03;
            }
            return Oldest;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates
            //the distance between them.
            //Point P01;
            //Point P02;

            //Console.WriteLine("Enter X1");
            //P01.X = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Y1");
            //P01.Y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter X2");
            //P02.X = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Y2");
            //P02.Y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Distance Btw This two point Is {GetDistance(P01, P02)}");
            #endregion

            #region Q2
            //2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program
            //that takes details of 3 persons as input from the user and displays the name and age
            //of the oldest person.
            Person P01, P02, P03;
            Console.WriteLine("Enter Person-1 Name");
            P01.Name = Console.ReadLine();
            Console.WriteLine("Enter Person-1 Age");
            P01.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Person-2 Name");
            P02.Name = Console.ReadLine();
            Console.WriteLine("Enter Person-2 Age");
            P02.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Person-3 Name");
            P03.Name = Console.ReadLine();
            Console.WriteLine("Enter Person-3 Age");
            P03.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"oldest Person is {GetOldestPerson(P01, P02, P03)}");
            #endregion
        }
    }
}
