namespace PatternPractic.Services
{
  /// <summary>
  /// Сервис по шифрованию.
  /// </summary>
  public interface IEncryptService
  {
    /// <summary>
    /// Шифровать данные.
    /// </summary>
    /// <param name="data">Шифруемые данные.</param>
    void Encrypt(object data);
  }
}
