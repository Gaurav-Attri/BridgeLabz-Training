internal class Contact
{
    private string contactName;
    private string contactEmail;
    private string phoneNumber;
    private string contactCity;
    
    public Contact(string contactName, string contactEmail, string phoneNumber,  string contactCity)
    {
        this.contactName = contactName;
        this.contactEmail = contactEmail; 
        this.phoneNumber = phoneNumber;
        this.contactCity = contactCity;
    }

    public string GetContactName()
    {
        return contactName; 
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public string GetContactCity()
    {
        return contactCity;
    }

    public string GetEmailId()
    {
        return contactEmail;
    }
    public override string ToString()
    {
        return $"\nContact Name: {contactName}\nContact Email: {contactEmail}\nPhone Number: {phoneNumber}\nContact City: {contactCity}\n";
    }

    public void SetContactName(string updatedName)
    {
        this.contactName = updatedName;
    }

    public void SetPhoneNumber(string updatedPhoneNumber)
    {
        this.phoneNumber = updatedPhoneNumber;
    }

    public void SetEmailId(string updatedEmailId)
    {
        this.contactEmail = updatedEmailId;
    }
}