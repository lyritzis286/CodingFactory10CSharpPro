
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Exceptions;

internal class InsuficientBalanceException : Exception
{
    public InsuficientBalanceException() : base("Insufficient balance for the operation.")
    {
    }

    public InsuficientBalanceException(string message) : base(message)

    {
    }

    public InsuficientBalanceException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
