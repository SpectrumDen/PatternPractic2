using System;

namespace DocumentExport.Decorators
{
  /// <summary>
  /// Сервис архивации данных.
  /// </summary>
  public class ArchiveService : Decorator
  {
    public override void Export(int id, string path)
    {
      base.Export(id, path);
      Console.WriteLine("Экспортированные данные заархивированы.");
      Console.WriteLine("-----------------------");
    }

    public ArchiveService(IExport exportServiceBase)
      : base(exportServiceBase)
    {
    }
  }
}
