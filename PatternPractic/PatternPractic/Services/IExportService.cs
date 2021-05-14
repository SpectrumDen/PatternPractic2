namespace PatternPractic.Services
{
  /// <summary>
  /// Контракт сервиса экспортированию объектов.
  /// </summary>
  public interface IExportService
  {
    /// <summary>
    /// Экспортировать объект.
    /// </summary>
    /// <param name="id">Id экспортируемого объекта.</param>
    /// <param name="path">Папка, куда будет экспортирован объект.</param> 
    void Export(int id, string path);

    /// <summary>
    /// Экспортировать объект с применением шифрования.
    /// </summary>
    /// <param name="id">Id экспортируемого объекта.</param>
    /// <param name="path">Папка, куда будет экспортирован объект.</param>
    void ExportWithEncrypt(int id, string path);
  }
}
