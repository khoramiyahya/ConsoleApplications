namespace ConsoleApplications;
public static class SalaryCalculator
{
    public static decimal GetSalary(int departmentId)
    {
        return departmentId switch
        {
            1 => 25000000m,
            2 => 100000000m,
            3 => 26000000m,
            _ => 0m
        };

    }
}

