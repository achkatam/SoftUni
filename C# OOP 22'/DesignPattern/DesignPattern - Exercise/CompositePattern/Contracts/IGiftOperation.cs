namespace CompositePattern.Contracts
{
    using CompositePattern.Models;
    
    public interface IGiftOperation
    {
        void Add(GiftBase gift);
        void Remove(GiftBase gift);
    }
}
