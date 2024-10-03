using System;

namespace LibExample.ExceptionExample;

/// Пример создания своего искючения.
public class ExceptionExample : Exception
{
    public ExceptionExample(string message) : base(message)
    {

    }
}