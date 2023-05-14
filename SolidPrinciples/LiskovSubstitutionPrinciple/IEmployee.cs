using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }

    public interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
    public abstract class NewEmployee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public NewEmployee()
        { }

        public NewEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;

        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        public abstract decimal GetMinimumSalary();
    }

    public class NewPermanentEmployee : NewEmployee
    {
        public NewPermanentEmployee()
        { }

        public NewPermanentEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .1M);
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }

    public class NewTemporaryEmployee : NewEmployee
    {
        public NewTemporaryEmployee()
        { }

        public NewTemporaryEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }

    public class NewContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public NewContractEmployee()
        { }

        public NewContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}
