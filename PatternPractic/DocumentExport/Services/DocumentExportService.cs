using System;
using System.Threading;
using System.Threading.Tasks;
using DocumentExport.Decorators;
using Microsoft.Extensions.Hosting;

namespace DocumentExport.Services
{
  /// <summary>
  /// Сервис экспорта документов.
  /// </summary>
  public class DocumentExportService : BackgroundService
  {
    private readonly IExport exportService;
    private readonly StorageService storageService;
    private readonly EncryptService encryptService;
    private readonly ArchiveService archiveService;

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while(!stoppingToken.IsCancellationRequested)
      {
        Console.WriteLine("1 - простой экспорт\n2 - шифровать\n3 - экспортировать в архив");
        Console.WriteLine("Введите команду: ");
        var command = Console.ReadLine();
        var client = new Client();
        switch (command)
        {
          case "1":
            client.ClientCode(exportService, 1, @"C:\Test\ASD");
            Console.WriteLine("Описание экспортированного компонента:");
            Console.WriteLine(storageService.Get(1).Description);
            Console.WriteLine();
            break;
          case "2":
            client.ClientCode(encryptService, 1, @"C:\Test\ASD");
            Console.WriteLine();
            break;
          case "3":
            client.ClientCode(archiveService, 1, @"C:\Test\ASD");
            Console.WriteLine();
            break;
          default:
            break;
        }
      }

      return Task.CompletedTask;
    }

    public DocumentExportService(
      IExport exportService,
      StorageService storageService,
      EncryptService encryptService,
      ArchiveService archiveService)
    {
      this.exportService = exportService;
      this.storageService = storageService;
      this.encryptService = encryptService;
      this.archiveService = archiveService;
    }
  }
}
