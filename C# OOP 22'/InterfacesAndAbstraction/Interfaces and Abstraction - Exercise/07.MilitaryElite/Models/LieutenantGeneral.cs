namespace MilitaryElite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;


    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly ICollection<IPrivate> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<IPrivate> privates)
            : base(id, firstName, lastName, salary)
        {
            this.privates = privates;
        }

        public IReadOnlyCollection<IPrivate> Privates
            => (IReadOnlyCollection<IPrivate>)this.privates;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine(base.ToString())
                .AppendLine($"Privates:");

            foreach (IPrivate pr in this.Privates)
            {
                sb.AppendLine($"  {pr.ToString()}");
            }


            return sb.ToString().TrimEnd();
        }
    }
}