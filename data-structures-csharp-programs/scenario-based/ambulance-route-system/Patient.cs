class Patient
{
    private string patientName;
    private int severity;

    public string GetPatientName()
    {
        return patientName;
    }

    public void SetPatientName(string value)
    {
        patientName = value;
    }

    public int GetSeverity()
    {
        return severity;
    }

    public void SetSeverity(int value)
    {
        severity = value;
    }

    public override string ToString()
    {
        return patientName + " | Severity: " + severity;
    }
}
