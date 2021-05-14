namespace PatternPractic
{
  public abstract class Component : IComponent
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; }

    public virtual void Display(int indent = 0)
    {

    }
  }
}
