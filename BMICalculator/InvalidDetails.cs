using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    [Serializable]
    internal class InvalidDetailsException : Exception
    {
        //public new string Message => "Invalid detials!";
        public double Weight { get; set; }
        public double Height { get; set; }
        public InvalidDetailsException() { }
        public InvalidDetailsException(string message ):base(message) { }  
        public InvalidDetailsException(string message, Exception innerException) : base(message, innerException) { }
    }
}
