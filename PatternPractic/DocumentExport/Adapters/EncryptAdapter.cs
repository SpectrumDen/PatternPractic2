using System;

namespace DocumentExport.Adapters
{
  /// <summary>
  /// Адаптер шифрования, делает интерфейс адаптируемого класса совместимым с целевым.
  /// </summary>
  public class EncryptAdapter
  {
    private readonly EncryptAdaptee encryptAdaptee;

    public void Encrypt()
    {
      encryptAdaptee.OtherEncrypt();
      Console.WriteLine("-----------------------");
    }

    public EncryptAdapter(EncryptAdaptee encryptAdaptee)
    {
      this.encryptAdaptee = encryptAdaptee;
    }
  }
}
