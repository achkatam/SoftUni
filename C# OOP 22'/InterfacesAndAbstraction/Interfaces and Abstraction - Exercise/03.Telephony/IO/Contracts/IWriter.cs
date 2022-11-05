namespace Telephony.IO.Contracts
{
 

    public interface IWriter
    {
        void Write(string text);

        void Writeline(string text);
    }
}
