using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class InvalidLevelException : Exception
    {
        public InvalidLevelException(string message) : base(message) { }
    }

    class InvalidConScoreException : Exception
    {
        public InvalidConScoreException(string message) : base(message) { }
    }

    class InvalidBurnTakenException : Exception
    {
        public InvalidBurnTakenException(string message) : base(message) { }
    }
}
