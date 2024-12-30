namespace Assignment
{

    internal struct Person
    {
        public string Name;
        public int Age;

        public override string ToString()
        {
            return $"({Name},{Age})";
        }
    }
}
