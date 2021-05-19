using System;
using PatternPractic.Services;

namespace PatternPractic.Services
{
  public class ArchiveService : IArchiveService
  {
    public void Archive(object data)
    {
      // Имитация архивации данных.
      Console.WriteLine("Данные помещены в архив.");
    }
  }
}
