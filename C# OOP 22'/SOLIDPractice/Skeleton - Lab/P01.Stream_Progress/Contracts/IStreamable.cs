namespace P01.Stream_Progress.Contracts
{

    public interface IStreamable
    {
        int Length { get; }

        int BytesSent { get; }
    }
}
