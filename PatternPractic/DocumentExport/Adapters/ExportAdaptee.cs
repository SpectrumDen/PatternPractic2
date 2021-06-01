using System;

namespace DocumentExport.Adapters
{
  /// <summary>
  /// Адаптируемый класс экспорта.
  /// </summary>
  public class ExportAdaptee
  {
    /// <summary>
    /// Экспорт данных с использованием сторонней библиотеки.
    /// </summary>
    /// <param name="name">Имя файла.</param>
    /// <param name="path">Путь к папке экспорта.</param>
    public void OtherExport(string name, string path)
    {
      Console.WriteLine($"'{name}' экспортирован в папку '{path}'");
    }
  }
}
