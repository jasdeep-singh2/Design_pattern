namespace OpenClosedPrinciple
{
    /// <summary>
    /// Notice here we have to modify the CalculateBonus function inside the class to make it compactible with the Temprary employee  to resolve this problem 
    /// make the class abstract and make the CalculateBonus function as abstact
    /// 1. Also we can remove employee type as it is no longer needed
    /// </summary>
    //public class Employee
    //{
    //    public Employee() { }
    //    public Employee(int id, string name, string type)
    //    {
    //        this.ID = id;
    //        this.Name = name;
    //        this.EmployeeType = type;
    //    }

    //    public int ID { get; set; }
    //    public string EmployeeType { get; set; }
    //    public string Name { get; set; }

    //    public decimal CalculateBonus(decimal salary)
    //    {
    //        if (this.EmployeeType == "Permanent")
    //            return salary * .1M;
    //        else
    //            return salary * .05M;
    //    }
    //}

    public abstract class Employee
    {
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
             return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .75M;
        }
    }
}
