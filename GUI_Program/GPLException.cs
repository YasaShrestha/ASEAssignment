using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program
{
    /*This is exception class to hand;le the errors in the code.
     */
    public class GPLException : Exception
    {
        string errorLine;
        public GPLException(): base("Something wrong with the program.") { }

        public GPLException(string message)
            : base(message) { }

        public GPLException(string message, int errorLine)
            : base(message+" Error at Line "+(errorLine+1)) { }

        public GPLException(string message, Exception inner)
            : base(message, inner) { }
    }
}
