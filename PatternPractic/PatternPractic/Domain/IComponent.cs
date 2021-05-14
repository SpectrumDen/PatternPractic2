namespace PatternPractic.Domain
{
  public interface IComponent
  {
    int Id { get; set; }
    string Name { get; set; }
    string Description { get; }
    void Display(int indent = 0);
  }
}
