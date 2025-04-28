
using System;

namespace BO;

[Serializable]
public class BLIdNotExist : Exception
{
    public BLIdNotExist(string? message) : base(message) { }
    public BLIdNotExist(string message, Exception innerException)
                : base(message, innerException) { }
}

[Serializable]
public class BLIdExist : Exception
{
    public BLIdExist(string? message) : base(message) { }
    public BLIdExist(string message, Exception innerException)
                : base(message, innerException) { }
}

[Serializable]
public class BLNoQuantityInStock : Exception
{
    public BLNoQuantityInStock(string? message) : base(message) { }
    public BLNoQuantityInStock(string message, Exception innerException)
                : base(message, innerException) { }
}

