internal class EmployeeMain
{
    public static Employee[] Employees;
    public static int Index = 0;
    public static int TotalEmployee = 2;

    static EmployeeMain()
    {
        Employees = new Employee[TotalEmployee];
    }

    public static void Main(string[] args)
    {
        EmployeeMenu employeeMenuObj = new EmployeeMenu();
        employeeMenuObj.EmployeeChoices();
    }
}
