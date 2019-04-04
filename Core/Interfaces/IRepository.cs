using System.Collections.Generic;
using Family.Core.Models;

namespace Family.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get();
    }
}