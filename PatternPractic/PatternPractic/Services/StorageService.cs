namespace PatternPractic
{
  public class StorageService : IStorageService
  {
    public IComponent Get(int id)
    {
      // Имитация получения данных с хранилища.
      return GetData(); 
    }

    private static IComponent GetData()
    {
      var folder = new Composite { Name = "Комплект 1", Id = 1 };
      var folder2 = new Composite { Name = "Комплект 2", Id = 2 };

      folder2.Add(folder);
      folder.Add(new Document { Name = "Документ 1", Id = 11 });
      folder.Add(new Document { Name = "Документ 2", Id = 12 });
      folder2.Add(new Document { Name = "Документ 3", Id = 21 });

      return folder2;
    }
  }
}
