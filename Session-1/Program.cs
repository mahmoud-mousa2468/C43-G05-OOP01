namespace Session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
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
            #endregion

            #region OOP Overview
            // OOP : Object Oriented Programming
            // Programming Paradigm
            // OOP : The Paradigm Use For Build Any Business

            //Class : Blueprint Of The Object
            //Object : Specific Instance From Class

            // 4 Pillars
            // ================

            // 1. Encapsulation
            // 2. Inheritance
            // 3. Ploymorphism
            // 4. Abstraction
            #endregion

            #region Encapsulation Using Setter Getter Methods
            // 1. Encapsulation :
            // Class Or Struct
            // Seperate The Data(Attributes) Definition From Its Use

            //Employee
            //Id Name Salary

            // 1. End User Access Data Itself
            // 2. No Data Validation
            // 3. No Read Only Filed

            // Apply Encapsulation
            //1. Make All Data(Attributes) private
            //2. Access Data Through
                // 2.1. Setter Getter Method
                // 2.2. Properties
            Employee E01 = new Employee();

            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.Salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.Salary);

            E01.SetId(1);
            E01.SetName("Ahmed");
            E01.SetSalary(12000);

            Console.WriteLine(E01.GetId());
            Console.WriteLine(E01.GetName());
            Console.WriteLine(E01.GetSalary());

            #endregion





        }
    }
}
