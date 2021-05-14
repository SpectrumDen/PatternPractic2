using System;

namespace PatternPractic
{
  /// <summary>
  /// Сервис по экспортированию документов.
  /// </summary>
  public class ExportService : IExportService
  {
    private readonly IStorageService storageService;

    public void Export(int id, string path)
    {
      var result = storageService.Get(id);

      // Тут вызов метода экспорт из сторонней библиотеки.
      // Для имитации вызова буду просто выводить на консоль.
      Console.WriteLine($"'{result.Name}' экспортирован в папку '{path}'");
      Console.WriteLine("-----------------------");
    }

    public ExportService(IStorageService storageService)
    {
      this.storageService = storageService;
    }
  }
}
