class Stage
{
    private readonly string _stageName;
    private ParcelLinkedList _parcels; 

    public Stage(string stageName)
    {
        _stageName = stageName;
        _parcels = new ParcelLinkedList();
    }

    public string GetStageName()
    {
        return _stageName;
    }

    public ParcelLinkedList GetParcels()
    {
        return _parcels;
    }
}