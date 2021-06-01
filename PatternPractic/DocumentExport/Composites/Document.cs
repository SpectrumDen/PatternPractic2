using System;
using System.Text;

namespace PatternPractic.Domain
{
  public class Document : Component
  {
    public override string Description => GetDescription();

    public override string GetDescription(int indent = 0)
    {
      var sb = new StringBuilder();
      var indentString = new string(' ', indent);
      sb.AppendLine($"{indentString}{this.Name}");
      return sb.ToString();
    }
  }
}