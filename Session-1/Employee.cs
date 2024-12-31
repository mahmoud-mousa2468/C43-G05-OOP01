namespace Session_1
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        // Apply Encapsulation User Setter Getter Method

        #region Encapsulation User Setter Getter Method
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}
        //public int GetId()
        //{
        //    return id;
        //}
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        //public string GetName()
        //{
        //    return name;
        //}
        //public void SetSalary(double Salary)
        //{
        //    this.Salary = Salary;
        //}
        //public double GetSalary()
        //{
        //    return Salary;
        //}

        //public Employee(int id, string name, double salary)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSalary(Salary);
        //} 
        #endregion


        // Apply Encapsulation User Properties


        #region Encapsulation Using Properties

        //1. Full Property
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { 
                if(value.Length>=0 && value.Length<=20)
                    name = value;
            }
            get { return name; }
        }
        public double Salary
        {
            set { 
                if(value>0)
                salary = value; }
            get { return salary; }
        }


        // Automatic Property
        public string Address { set; get; }

        #endregion
    }
}
