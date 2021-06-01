namespace PatternPractic.Domain
{
  /// <summary>
  /// Контракт компонента.
  /// <para>
  /// Описание как документа, так и компонента.
  /// </para>
  /// </summary>
  public interface IDocument
  {
    /// <summary>
    /// Id компонента.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Наименование компонента.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Описание компонента.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Получить описание компонента.
    /// </summary>
    /// <param name="indent">Размер отступа.</param>
    /// <returns>Отформатированное описание компонента.</returns>
    string GetDescription(int indent = 0);
  }
}
