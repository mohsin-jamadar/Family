using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Core.Interfaces
{
    public interface ICommandDictionary<T> where T : class
    {
        Dictionary<string, ICommand<T>> GetDictionary();
    }
}
