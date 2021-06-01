namespace PatternPractic.Domain
{
  /// <summary>
  /// Базовый класс компонента.
  /// </summary>
  public abstract class Component : IDocument
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public abstract string Description { get; }

    public abstract string GetDescription(int indent = 0);
  }
}
