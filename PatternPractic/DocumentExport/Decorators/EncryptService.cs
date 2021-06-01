using DocumentExport.Adapters;

namespace DocumentExport.Decorators
{
  /// <summary>
  /// Сервис шифрования данных.
  /// </summary>
  public class EncryptService : Decorator
  {
    private readonly EncryptAdapter encryptAdapter;

    public override void Export(int id, string path)
    {
      base.Export(id, path);
      encryptAdapter.Encrypt();
    }

    public EncryptService(IExport exportServiceBase, EncryptAdapter encryptAdapter)
      : base(exportServiceBase)
    {
      this.encryptAdapter = encryptAdapter;
    }
  }
}
