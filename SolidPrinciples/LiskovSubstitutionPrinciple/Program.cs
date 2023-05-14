using LiskovSubstitutionPrinciple;

List<NewEmployee> employees = new List<NewEmployee>();
employees.Add(new NewPermanentEmployee(1, "John"));
employees.Add(new NewTemporaryEmployee(2, "Jason"));
//Un Comment to see the error
//employees.Add(new ContractEmployee(3, "Mike"));
foreach (var employee in employees)
{
    Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
    employee.ToString(),
    employee.CalculateBonus(100000).ToString(),
    employee.GetMinimumSalary().ToString()));
}

Console.WriteLine();

List<IEmployee> employeesOnly = new List<IEmployee>();

employeesOnly.Add(new NewPermanentEmployee(1, "John"));
employeesOnly.Add(new NewTemporaryEmployee(2, "Jason"));
employeesOnly.Add(new NewContractEmployee(3, "Mike"));

foreach (var employee in employeesOnly)
{
    Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
    employee.ToString(),
    employee.GetMinimumSalary().ToString()));
}
Console.ReadLine();