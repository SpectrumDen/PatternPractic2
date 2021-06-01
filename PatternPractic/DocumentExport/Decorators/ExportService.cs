using DocumentExport.Adapters;
using DocumentExport.Services;

namespace DocumentExport.Decorators
{
  /// <summary>
  /// Сервис по экспорту данных.
  /// </summary>
  public class ExportService : IExport
  {
    private readonly ExportAdapter exportAdapter;
    private readonly StorageService storageService;

    public void Export(int id, string path)
    {
      var result = storageService.Get(id);
      exportAdapter.Export(result.Name, path);
    }

    public ExportService(ExportAdapter exportAdapter, StorageService storageService)
    {
      this.exportAdapter = exportAdapter;
      this.storageService = storageService;
    }
  }
}
