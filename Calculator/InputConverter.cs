using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput) // data type in method will have a return value
        {
            double convertedNumber; // variable created to hold value for TryParse
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value");
            return convertedNumber;
        }
    }
}
 