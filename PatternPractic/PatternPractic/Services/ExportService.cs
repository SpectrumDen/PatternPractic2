using System;

namespace PatternPractic.Services
{
  /// <summary>
  /// Сервис по экспортированию документов.
  /// </summary>
  public class ExportService : IExportService
  {
    private readonly IStorageService storageService;
    private readonly IEncryptService encryptService;

    public void Export(int id, string path)
    {
      var result = storageService.Get(id);

      // Тут вызов метода экспорт из сторонней библиотеки.
      // Для имитации вызова буду просто выводить на консоль.
      Console.WriteLine($"'{result.Name}' экспортирован в папку '{path}'");
      Console.WriteLine("-----------------------");
    }

    public void ExportWithEncrypt(int id, string path)
    {
      Export(id, path);

      encryptService.Encrypt(new object());
    }

    public ExportService(
      IStorageService storageService,
      IEncryptService encryptService)
    {
      this.storageService = storageService;
      this.encryptService = encryptService;
    }
  }
}
