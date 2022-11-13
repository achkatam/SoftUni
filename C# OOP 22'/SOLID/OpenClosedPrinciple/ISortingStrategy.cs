namespace OpenClosedPrinciple
{
    using System;
    using System.Collections.Generic;
    
    public interface ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data);
    }
}
