using System;
using System.Collections.Generic;
using System.Text;

namespace Models;

public class OperationResult
{
    public bool Success { get; init; }
    public string Message { get; init; }
    public static OperationResult Ok()=>new OperationResult() { Success=true};
    public static OperationResult Failed(string message)=>new OperationResult() { Success=false,Message=message};
}
public class OperationResult<T>:OperationResult
{
    private OperationResult()
    {
        
    }
    public T Data { get; private set; }
    public static OperationResult<T> Ok(T data)=>new OperationResult<T> { Success=true,Data=data };
    public static OperationResult<T> Failed(string message)=>new OperationResult<T> { Success=false,Message=message};
    
}
