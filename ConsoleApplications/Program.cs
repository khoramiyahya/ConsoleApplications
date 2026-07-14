using System.Text;

namespace ConsoleApplications;
    internal class Program
    {
        static void Main(string[] args)
        {
        Employee employee1 = new Employee(firstName: "Vahid", lastName: "Dakhili", departmentId: 1) { };
        Employee employee2 = new Employee(firstName : "Yahya",lastName : "Khorami",departmentId : 2){ };
        Employee employee3 = new Employee(firstName: "AliAkbar", lastName: "Behnik", departmentId: 3) { };

        employee1.PrintInfo();
        employee2.PrintInfo();
        employee3.PrintInfo();

        decimal[] totalSalary = new decimal[3];

        totalSalary[0] = employee1.Salary;
        totalSalary[1] = employee2.Salary;
        totalSalary[2] = employee3.Salary;

        decimal allEmployeeSalary = new();

        decimal highestSalary = 0m;

        foreach(var salary in totalSalary)
        {
            allEmployeeSalary += salary;
            if(salary>highestSalary)
            {
                highestSalary = salary;
            }
        }

        decimal averageEmployeesSalary = Math.Round(allEmployeeSalary / totalSalary.Length);
        Console.WriteLine();
        Console.WriteLine("---------- Aggrigate Information ----------");
        Console.WriteLine($"Average Salary : {averageEmployeesSalary:c}");
        Console.WriteLine($"Highest Salary : {highestSalary:c}");

    }
    }

