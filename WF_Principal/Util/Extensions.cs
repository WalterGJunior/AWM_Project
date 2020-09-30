using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Principal.Util
{
    public static class Extensions
    {
        public static bool IsNullOrZero(this int? numero)
        {
            return numero == null || numero.Value == default(int);
        }

        public static string RemoveFormatacao(this string palavra)
        {
            // Remove os pontos vírgulas e traços da string...
            return palavra.Replace(".", string.Empty).Replace("-",string.Empty).Replace(",",string.Empty);
        }
    }
}
