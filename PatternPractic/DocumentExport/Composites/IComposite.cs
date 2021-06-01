namespace PatternPractic.Domain
{
  /// <summary>
  /// Контракт компоновщика. 
  /// </summary>
  public interface IComposite : IDocument
  {
    /// <summary>
    /// Добавить компонент в компоновщик.
    /// </summary>
    /// <param name="component"></param>
    void Add(IDocument component);
  }
}
