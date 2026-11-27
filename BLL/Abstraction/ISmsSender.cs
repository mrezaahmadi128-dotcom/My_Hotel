using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstraction;

public interface ISmsSender
{
     Task<OperationResult> SendAsync(string mobileNumber, string message);

}
