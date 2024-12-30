namespace Session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Struct : Value Type :Stack

            Point P01;
            //Declare For Object From Type 'Point'
            //P01:Object
            //Allocate UnInitialized 8 Bytes At The Stack

            P01.X = 12;
            P01.Y = 13;
            Console.WriteLine(P01.X);
            Console.WriteLine(P01.Y);

            // when you use new so you use the constructor which set all Variables to default value(0)
            P01 = new Point(1, 2);
            Console.WriteLine(P01.Y);


            //Console.WriteLine(P01); // Session_1.Point

            //P01.PrintPoint();


            //Console.WriteLine(P01.ToString()); //Session_1.Point

            // output change based on the override on tostring
            Console.WriteLine(P01.ToString()); //(1,2)

            // output change based on the override on tostring
            Console.WriteLine(P01); //(1,2)





        }
    }
}
