namespace PatternPractic.Services
{
  /// <summary>
  /// Сервис для архивации данных.
  /// </summary>
  public interface IArchiveService
  {
    /// <summary>
    /// Архивировать данные.
    /// </summary>
    /// <param name="data">Данные для архивации.</param>
    void Archive(object data);
  }
}
