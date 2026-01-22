class Building
{
    private string name;
    private bool isAvailable;

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public bool GetAvailability()
    {
        return isAvailable;
    }

    public void SetAvailability(bool value)
    {
        isAvailable = value;
    }

    public override string ToString()
    {
        return name + " | Available: " + isAvailable;
    }
}
