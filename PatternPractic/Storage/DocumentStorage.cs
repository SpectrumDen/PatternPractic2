using System;
using System.Collections.Generic;

namespace Storage
{
  /// <summary>
  /// Хранилище документов.
  /// </summary>
  public class DocumentStorage
  {
    public List<Document> Documents { get; set; } 

    public void Add(Document document) { }
    public void Delete(Guid documentId) { }
    public void Get(Guid documentId) { }

    public DocumentStorage()
    {
      Documents = new List<Document>
      {
        new Document(new byte[4] { 1, 4, 6, 9 }),
        new Document(new byte[3] { 2, 56, 67}),
        new Document(new byte[2] { 23, 56}),
      };
    }
  }
}
