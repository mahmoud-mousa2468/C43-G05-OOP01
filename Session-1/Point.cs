namespace Session_1
{
    internal struct Point
    {
        public int X = default;
        public int Y = default;


        // Constructor : Special Methods
        //             1- Named Like Struct
        //             2- Has No Return Type

        //Constructor
        //Public Point()
        //{

        //}

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"({X},{Y})");
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
