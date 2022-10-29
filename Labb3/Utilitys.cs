using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    internal static class Utilitys
    {
        public static string PropertyList(this object obj)
        {
            var props = obj.GetType().GetProperties();
            var sb = new StringBuilder();
            foreach (var p in props)
            {
                sb.AppendLine(p.Name + ": " + p.GetValue(obj));
            }
            return sb.ToString();
        }
    }
}
