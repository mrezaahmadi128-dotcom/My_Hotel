using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstraction;

internal interface ISmsSender
{
     Task<OperationResult> SendAsync(string mobileNumber, string message);
}
