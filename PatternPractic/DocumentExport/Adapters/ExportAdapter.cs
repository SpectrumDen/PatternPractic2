using System;

namespace DocumentExport.Adapters
{
  /// <summary>
  /// Адаптер экспорта, делает интерфейс адаптируемого класса совместимым с целевым.
  /// </summary>
  public class ExportAdapter
  {
    private readonly ExportAdaptee exportAdaptee;

    public void Export(string name, string path)
    {
      exportAdaptee.OtherExport(name, path);
      Console.WriteLine("-----------------------");
    }

    public ExportAdapter(ExportAdaptee exportAdaptee)
    {
      this.exportAdaptee = exportAdaptee;
    }
  }
}
