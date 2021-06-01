namespace DocumentExport.Services
{
  /// <summary>
  /// Клиентский код, для имитации бурной деятельности.
  /// </summary>
  public class Client
  {
    public void ClientCode(IExport exportServiceBase, int id, string path)
    {
      exportServiceBase.Export(id, path);
    }
  }
}
