namespace P04.Recharge.Models
{
    using P04.Recharge.Models.Contracts;

    public class Robot : Worker, IRechargeable
    {
        private int capacity;
        private int currentPower;

        public Robot(string id, int capacity) : base(id)
        {
            this.capacity = capacity;
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public int CurrentPower
        {
            get { return currentPower; }
            set { currentPower = value; }
        }

        /// <summary>
        /// User the key word "new" otherwise it gives u a warning!
        /// </summary>
        public new void Work(int hours)
        {
            if (hours > currentPower)
            {
                hours = currentPower;
            }

            base.Work(hours);
            currentPower -= hours;
        }

        public void Recharge()
        {
            currentPower = capacity;
        }
    }
}