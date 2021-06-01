namespace DocumentExport.Decorators
{
  /// <summary>
  /// Базовый класс декоратора.
  /// </summary>
  public abstract class Decorator : IExport
  {
    protected IExport exportServiceBase;

    public virtual void Export(int id, string path)
    {
      if (this.exportServiceBase != null)
        this.exportServiceBase.Export(id, path);
    }

    public Decorator(IExport exportServiceBase)
    {
      this.exportServiceBase = exportServiceBase;
    }
  }
}
