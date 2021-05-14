using System;
using System.Collections.Generic;

namespace PatternPractic
{
  /// <summary>
  /// Комплект объектов.
  /// </summary>
  public class Composite : IComposite
  {
    private readonly List<IComponent> components = new List<IComponent>();

    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; }

    public void Add(IComponent component)
    {
      this.components.Add(component);
    }

    public void Display(int indent = 0)
    {
      var indentString = indent.GetIndentString();
      var childrenIndent = ++indent;
      Console.WriteLine($"{indentString}{this.Name}");
      foreach (var item in this.components)
      {
        item.Display(childrenIndent);
      }
    }
  }
}
