namespace PatternPractic.Domain
{
  public interface IComposite : IComponent
  {
    void Add(IComponent component);
  }
}
