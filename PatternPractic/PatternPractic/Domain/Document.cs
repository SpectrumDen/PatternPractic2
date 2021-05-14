using System;

namespace PatternPractic
{
  public class Document : Component
  {
    public override void Display(int indent = 0)
    {
      var indentString = indent.GetIndentString();
      Console.WriteLine($"{indentString}{this.Name}");
    }
  }
}
