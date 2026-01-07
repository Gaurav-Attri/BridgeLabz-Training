internal class EmployeeMain
{
    public static Employee[] Employees;
    public static int Index = 0;
    public static int TotalEmployee = 10;

    static EmployeeMain()
    {
        Employees = new Employee[TotalEmployee];

        Employees[Index++] = new Employee("Rahul", 1, true, 100, "Full-Time");
        Employees[Index++] = new Employee("Anita", 2, false, 120, "Full-Time");
        Employees[Index++] = new Employee("Vikas", 3, true, 150, "Full-Time");
        Employees[Index++] = new Employee("Sneha", 4, true, 110, "Full-Time");
        Employees[Index++] = new Employee("Amit", 5, false, 90, "Full-Time");
        Employees[Index++] = new Employee("Anita", 6, false, 50, "Part-Time");
        Employees[Index++] = new Employee("Anita", 7, false, 40, "Part-Time");
    }

    public static void Main(string[] args)
    {
        EmployeeMenu employeeMenuObj = new EmployeeMenu();
        employeeMenuObj.EmployeeChoices();
    }
}
