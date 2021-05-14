using System;
using PatternPractic.Services;

namespace PatternPractic
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var storageService = new StorageService();
      var encryptService = new EncryptService();
      var exportService = new ExportService(storageService, encryptService);

      while (true)
      {
        Console.WriteLine("1 - простой экспорт\n2 - шифровать\n3 - экспортировать в архив");
        Console.WriteLine("Введите команду: ");
        var command = Console.ReadLine();
        switch (command)
        {
          case "1":
            exportService.Export(1, @"C:\Test\ASD");
            Console.WriteLine("Описание экспортированного компонента:");
            storageService.Get(1).Display();
            break;
          case "2":
            exportService.ExportWithEncrypt(1, @"D:\Asd");
            break;
          case "3":

            break;

          default:
            break;
        }
      }
    }
  }
}
