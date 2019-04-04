using System.Collections.Generic;
using Family.Core.Models;

namespace Family.Core.Interfaces
{
    public interface ICommand<T> where T:class
    {
        string Execute(T entity,List<string> parameters);
    }
}
