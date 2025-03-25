﻿namespace kontenery.Properties.exceptions;

public class OverfillException : System.Exception
{
    public OverfillException()
    {
    }

    public OverfillException(string message)
        : base(message)
    {
    }

    public OverfillException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}