namespace PatternPractic
{
  /// <summary>
  /// Контракт сервиса хранилищ.
  /// </summary>
  public interface IStorageService
  {
    /// <summary>
    /// Получить объект из хранилища.
    /// </summary>
    /// <param name="id">Id объекта.</param>
    /// <returns>Объект.</returns>
    IComponent Get(int id);
  }
}
