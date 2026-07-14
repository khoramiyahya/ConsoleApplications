namespace ConsoleApplications;
 public class Employee
    {
    public Employee(string firstName,string lastName,int departmentId)
    {
        Id = IdGenerator.GetId();
        FirstName = firstName;
        LastName = lastName;
        DepartmentId = departmentId;
        Salary = SalaryCalculator.GetSalary(departmentId: DepartmentId);
    }
    private int Id;
    public string FirstName { get;  set; }
    public string LastName { get; set; }
    public int DepartmentId { get; set; }
    public decimal Salary { get; }
    public  string FullName { get { return $"{FirstName} {LastName}";} }


    public void PrintInfo () {
        Console.WriteLine();
        Console.WriteLine("--------------Information--------------");
        Console.WriteLine($"{FullName} - {Salary:C}");
    }

}

