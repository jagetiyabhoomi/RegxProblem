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
        public String REGX_EMAIL = "^[a-zA-Z0-9]+[a-zA-z.]*@[a-zA-Z0-9]+[.]+[a-zA-z]+[.a-zA-z]*$";
        public bool boolvalidate(string email)
        {
            return Regex.IsMatch(email, REGX_EMAIL);
        }
    }
}
