using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BinarisKeresoFa
{
    class InvalidExpressionException : Exception
    {
        public InvalidExpressionException(string expression, int position) : base($"Invalid character found at position: {position}, in the following expression: '{expression}'!")
        {

        }
        public override string ToString()
        {
            return $"InvalidExpressionException: {Message}";
        }
    }
}
