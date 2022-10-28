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
        public  String REGX_FNAME = "^[A-Z]{1}[A-Z a-z]{2,3}$";
        public bool boolvalidate(string Fname)
        {
            return Regex.IsMatch(Fname, REGX_FNAME);
        }
    }
}
