namespace LiskovSubtitutionPrinciple
{

    public interface IEmployee : IWorker
    {
        void Sleep();

        void GetSalary();
    }
}
