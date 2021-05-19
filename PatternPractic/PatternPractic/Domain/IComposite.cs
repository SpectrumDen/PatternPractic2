namespace PatternPractic.Domain
{
  public interface IComposite : IDocument
  {
    void Add(IDocument component);
  }
}
