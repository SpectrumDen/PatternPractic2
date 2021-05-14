using System.Text;

namespace PatternPractic.Extensions
{
  public static class IntExtensions
  {
    public static string GetIndentString(this int indent)
    {
      var result = new StringBuilder();
      for (int i = 0; i < indent; i++)
      {
        result.Append(" ");
      }

      return result.ToString();
    }
  }
}
