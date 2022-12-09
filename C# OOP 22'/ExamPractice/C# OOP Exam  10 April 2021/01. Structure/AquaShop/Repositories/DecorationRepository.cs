using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly ICollection<IDecoration> decorations;

        public DecorationRepository()
        {
            this.decorations = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models => (IReadOnlyCollection<IDecoration>)this.decorations;

        public void Add(IDecoration model) =>this.decorations.Add(model);

        public IDecoration FindByType(string type) => this.decorations.FirstOrDefault(x => x.GetType().Name == type);

        public bool Remove(IDecoration model) => this.decorations.Remove(model);
    }
}
