namespace Session_1
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double Salary;

        // Apply Encapsulation User Setter Getter Method

        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSalary(double Salary)
        {
            this.Salary = Salary;
        }
        public double GetSalary()
        {
            return Salary;
        }

        public Employee(int id, string name, double salary)
        {
            SetId(id);
            SetName(name);
            SetSalary(Salary);
        }
    }
}
