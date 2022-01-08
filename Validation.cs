using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Jacques_Gourmand
{
    public class StringNotEmpty : ValidationRule
    {
            
            public override ValidationResult Validate(object value,
            System.Globalization.CultureInfo cultureinfo)
            {
                string aString = value.ToString();
                if (aString == "")
                    return new ValidationResult(false, "String cannot be empty");
                return new ValidationResult(true, null);
            }
        }
    
}