namespace InterfaceSegregation
{
    public interface IBankAccount : IBalance, IDeposit, IPay, IWithdraw
    {
    }
}
