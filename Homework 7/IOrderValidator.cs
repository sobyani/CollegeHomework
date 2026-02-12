using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    public interface IOrderValidator
    {
        bool Validate(string itemName, int quantity, Action<string> errorCallback);
    }
}
