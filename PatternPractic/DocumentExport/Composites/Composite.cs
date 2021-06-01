using System.Collections.Generic;
using System.Text;

namespace PatternPractic.Domain
{
  /// <summary>
  /// Комплект объектов.
  /// </summary>
  public class Composite : IComposite
  {
    private readonly List<IDocument> components = new List<IDocument>();

    public int Id { get; set; }
    public string Name { get; set; }

    public string Description => GetDescription();

    public void Add(IDocument component)
    {
      this.components.Add(component);
    }

    public string GetDescription(int indent = 0)
    {
      var sb = new StringBuilder();
      var indentString = new string(' ', indent);
      var childrenIndent = ++indent;
      sb.AppendLine($"{indentString}{this.Name}");
      foreach (var item in this.components)
      {
        sb.Append(item.GetDescription(childrenIndent));
      }

      return sb.ToString();
    }
  }
}
