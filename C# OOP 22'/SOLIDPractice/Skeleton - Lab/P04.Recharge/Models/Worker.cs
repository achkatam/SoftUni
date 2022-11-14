namespace P04.Recharge.Models
{
    using P04.Recharge.Models.Contracts;

    public  class Worker
    {
        private string id;
        private int workingHours;

        public Worker(string id)
        {
            this.id = id;
        }

        public virtual void Work(int hours)
        {
            workingHours += hours;
        }
    }
}