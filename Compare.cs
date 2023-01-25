using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  internal class Compare
  {
    public static bool Equal(string a, string b)
      => string.Equals(a, b);

    public static bool Equal(double a, double b)
      => double.Equals(a, b);

    public static bool Equal(int a, int b)
      => int.Equals(a, b);
  }
}
