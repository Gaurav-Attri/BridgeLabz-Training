internal class EmployeeUtilityImpl : IEmployee
{
    private static int automaticEmployeeId;

    static EmployeeUtilityImpl()
    {
        automaticEmployeeId = 7; // As 7 employees are already present in the employees array
    }

    public Employee AddEmployee()
    {
        Console.WriteLine("\n=== Employee Adding Window ===\n");
        Console.Write("Enter employee name: ");
        string employeeName = Console.ReadLine();

        Console.Write("Enter employee attendance (true/false): ");
        bool employeeAttendance = bool.Parse(Console.ReadLine());

        Console.Write("Enter wage per hour: ");
        double wagePerHour = double.Parse(Console.ReadLine());

        Console.Write("Enter employee type: ");
        string employeeType = Console.ReadLine();

        Employee employee = new Employee(
            employeeName,
            ++automaticEmployeeId,
            employeeAttendance,
            wagePerHour,
            employeeType
        );

        return employee;
    }

    public bool CheckEmployeeAttendance()
    {
        Console.WriteLine("\n=== Employee Attendance Checking Window ===\n");
        Console.Write("Enter Employee Id: ");
        int employeeId = int.Parse(Console.ReadLine());

        foreach (Employee employee in EmployeeMain.Employees)
        {
            if (employee != null && employee.GetEmployeeId() == employeeId)
            {
                return employee.GetIsPresent();
            }
        }
        Console.WriteLine("Employee Doesn't exist\n");
        return false;
    }

    public double CalculateDailyEmployeeWage()
    {
        Console.Write("\nEnter Employee Id: ");
        int employeeId = int.Parse(Console.ReadLine());

        foreach (Employee employee in EmployeeMain.Employees)
        {
            if (employee != null && employee.GetEmployeeId() == employeeId)
            {
                if (employee.GetIsPresent())
                {
                    return employee.GetWagePerHour() * 8;
                }
                return 0;
            }
        }

        return 0;
    }
}
