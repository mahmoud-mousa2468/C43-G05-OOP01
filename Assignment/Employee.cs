namespace Assignment
{
    public class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime hiredate;


        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
            hiredate = new DateTime(year, month, day);
        }
    }
    public enum SL
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    internal class Employee : HireDate
    {
        #region Attributes
        private SL securitylevel;
        private int id;
        private string name;
        private double salary;
        private char gender;
        #endregion

        #region Seter&Geter
        public SL GetSL()
        {
            return securitylevel;
        }
        public void SetSl(SL NewSL)
        {
            try
            {
                securitylevel = NewSL;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int Id)
        {
            try
            {
                id = Id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string Name)
        {
            try
            {
                name = Name;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public double GetSalary()
        {
            return salary;
        }
        public void SetSalary(double Salary)
        {
            try
            {
                salary = Salary;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public char GetGender()
        {
            return gender;
        }
        public void SetGender(char Gender)
        {
            if ((Gender.ToString().ToLower() == "m") || (Gender.ToString().ToLower() == "f"))
                gender = Gender;
            else
                Console.WriteLine("Insert M for Male and F For Female");
        }
        public DateTime GetHireDate()
        {
            return hiredate;
        }
        #endregion

        public Employee(SL sL, int id, string name, double salary, HireDate hiredate, char gender) : base(hiredate.Day, hiredate.Month, hiredate.Year)
        {
            SetSl(sL);
            SetId(id);
            SetName(name);
            SetSalary(salary);
            SetGender(gender);
        }

        public override string ToString()
        {
            return $"Id: {GetId()} :: Name: {GetName()} :: Security_Level :: {GetSL()} :: Salary :: {GetSalary():C} :: HireDate :: ({Day}/{Month}/{Year}) :: Gender : {GetGender()}";
        }
        //public SL SecurityLevel
        //{
        //    get { return securitylevel; }
        //    set { securitylevel = value; }
        //}
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //public double Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }
        //}
        //public char Gender
        //{
        //    get { return gender; }
        //    set
        //    {
        //        switch (value)
        //        {
        //            case 'M':
        //            case 'm':
        //            case 'F':
        //            case 'f':
        //                gender = value;
        //                break;
        //            default:
        //                Console.WriteLine("Insert M for Male and F For Female");
        //                break;
        //        }
        //    }
        //}

        //public SL SecurityLevel { get; set; }
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double Salary { get; set; }
    }
}
