using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput) // data type in method definition will return a value
        {
            double convertedNumber; // variable created to hold value for TryParse

            // skips variable assignment of boolean and places bool value directy inside conditional statement
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value"); 
            return convertedNumber;
        }
    }
}
 