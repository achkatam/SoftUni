namespace Telephony.Models.Contracts
{

    public interface ISmartphone : IStationaryPhone
    {
        string BrowseURL(string url);
    }
}
