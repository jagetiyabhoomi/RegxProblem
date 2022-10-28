using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class Patterns
    {
        public String REGX_PASS = "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$";
        public bool boolvalidate(string pass)
        {
            return Regex.IsMatch(pass, REGX_PASS);
        }
    }
}
