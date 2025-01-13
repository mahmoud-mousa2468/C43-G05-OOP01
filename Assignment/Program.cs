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
            //Person P01, P02, P03;
            //Console.WriteLine("Enter Person-1 Name");
            //P01.Name = Console.ReadLine();
            //Console.WriteLine("Enter Person-1 Age");
            //P01.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Person-2 Name");
            //P02.Name = Console.ReadLine();
            //Console.WriteLine("Enter Person-2 Age");
            //P02.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Person-3 Name");
            //P03.Name = Console.ReadLine();
            //Console.WriteLine("Enter Person-3 Age");
            //P03.Age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"oldest Person is {GetOldestPerson(P01, P02, P03)}");
            #endregion

            #region Q3

            //1.Design and implement a Class for the employees in a company:
            //Notes:
            //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //We need to restrict the Gender field to be only M or F[Male or Female] 
            //Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
            //display employee salary in a currency format. [Use String.Format() Function].
            //Develop a Class to represent the Hiring Date Data: Consisting of fields to hold the day, month and Years.
            //Create an array of Employees with size three a DBA, Guest and the third one is security officer
            //who have full permissions. (Employee[] EmpArr;)

            //Notes:
            //Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //Define all the Necessary Constructors for the Class
            //Allow NO RUNTIME errors if the user inputs any data
            //Write down all the necessary Properties(Instead of setters and getters)


            //Sort the employees based on their hire date then Print the sorted array.
            //While sorting(how many times Boxing and Unboxing process has occurred)


            //    int Boxing = 0;
            //    int UnBoxing = 0;

            //    Employee[] Employees = new Employee[3]
            //    {
            //      new Employee(SL.DBA,1,"Ahmed",5000,new HireDate(1,2,2055),'M'),
            //      new Employee(SL.Guest,2,"Lila",30000,new HireDate(10,5,2000),'F'),
            //      new Employee(SL.SecurityOfficer,1,"Amir",5052000,new HireDate(20,2,2095),'M'),
            //};
            //    Console.WriteLine("The Array Before Sorting");
            //    foreach (var employee in Employees)
            //    {
            //        Console.WriteLine(employee);

            //    }
            //    Console.WriteLine("The Array After Sorting");
            //    Array.Sort(Employees, (X, Y) => X.GetHireDate().CompareTo(Y.GetHireDate()));
            //    foreach (var employee in Employees)
            //    {
            //        Console.WriteLine(employee);
            //        Boxing++;
            //        UnBoxing++;
            //    }
            //    Console.WriteLine($"Boxing Time Is {Boxing}");
            //    Console.WriteLine($"UnBoxing Time Is {UnBoxing}");


            #endregion
        }
    }
}
