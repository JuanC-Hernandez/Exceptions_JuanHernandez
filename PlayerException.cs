using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_JuanHernandez
{
    internal class PlayerException : Exception
    {
        // Constructors
        public PlayerException() { } // Default
        public PlayerException(string message) { }
        PlayerException(string message, Exception inner):base(message, inner) { }   
    }
}
