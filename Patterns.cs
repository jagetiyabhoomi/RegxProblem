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
        public String REGX_PHONE = "^91( )+[7-9]{1}?[0-9]{9}?$";
        public bool boolvalidate(string phone)
        {
            return Regex.IsMatch(phone, REGX_PHONE);
        }
    }
}
