using System;

namespace Storage
{
  /// <summary>
  /// Документ.
  /// </summary>
  public class Document
  {
    public Guid Id { get; set; }
    public byte[] Content { get; set; }

    public Document(byte[] content)
    {
      this.Content = content;
      this.Id = Guid.NewGuid();
    }
  }
}