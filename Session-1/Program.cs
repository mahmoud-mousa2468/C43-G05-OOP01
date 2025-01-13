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




            #region Indexer

            ////Indexer: Special Property
            ////    / 1.Named This
            //    //PhoneBook

            //    PhoneBook phoneBook = new PhoneBook(3);
            //    phoneBook.AddPerson("Ahmed", 111, 0);
            //    phoneBook.AddPerson("omar", 222, 1);
            //    phoneBook.AddPerson("mo", 333, 3);

            //    Console.WriteLine(phoneBook.GetNumber("Ahmed"));
            //    phoneBook.updateNumber("Ahmed", 999);
            //    Console.WriteLine(phoneBook.GetNumber("Ahmed"));

            //    // take name and get number give us ability to treate struct as array
            //    Console.WriteLine(phoneBook["Ahmed"]); //long
            //    phoneBook["Ahmed"] = 11111;  // long

            //    // take number and get name give us ability to treate struct as array
            //    Console.WriteLine(phoneBook[111]); //long

            #endregion

            #region Class Internal Constructor Chaining
            //Car C01;
            //Declare For Reference (Pointer) From Type 'Car'
            //C01 :Can Refer To Object From Type 'Car' Or Any Class Inherited from it
            // c01 : refer To Null

            //Console.WriteLine(C01);

            //8 Bytes Will Be Allocated At Stack For The Reference 'C01'
            // 0 Bytes Will Be Allocated At Heap

            //C01 = new Car(1, 200, "XYZ");
            
            //new
            //1-Allocate The Number Of Required Bytes At Heap For The Object
            //2-Initailized The Allocated Bytes With The Default Value 
            //3-Call User-Defined Constructor If Exists
            //4- Assign The Object To The Reference

            //Console.WriteLine(C01.Id);
            //Console.WriteLine(C01.Model);
            //Console.WriteLine(C01.Speed);

            //Console.WriteLine(C01);


            #endregion

        }
    }
}
