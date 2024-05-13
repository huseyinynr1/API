using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, bool success, string message) : base(data, success, message)
        {
        }

        public SuccessDataResult(T data) : base(data, success: true)
        {
        }

        public SuccessDataResult(string message) : base(default, success: true, message)
        {

        }
    }
}