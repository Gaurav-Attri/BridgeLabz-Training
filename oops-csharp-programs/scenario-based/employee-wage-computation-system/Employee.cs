internal class Employee
{
    private string EmployeeName;
    private int EmployeeId;
    private bool IsPresent;
    private double WagePerHour;
    private string EmployeeType;

    public Employee(string EmployeeName, int EmployeeId, bool IsPresent, double WagePerHour, string EmployeeType)
    {
        this.EmployeeName = EmployeeName;
        this.EmployeeId = EmployeeId;
        this.IsPresent = IsPresent;
        this.WagePerHour = WagePerHour;
        this.EmployeeType = EmployeeType;
    }

    public string GetEmployeeName()
    {
        return EmployeeName;
    }

    public int GetEmployeeId()
    {
        return EmployeeId;
    }

    public bool GetIsPresent()
    {
        return IsPresent;
    }

    public override string ToString()
    {
        return $"\nEmployee Name: {EmployeeName}\nEmployee id: {EmployeeId}\nEmployee Attendance: {IsPresent}\n";
    }
}
