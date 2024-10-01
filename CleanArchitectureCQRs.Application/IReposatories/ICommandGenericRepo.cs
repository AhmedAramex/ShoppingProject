using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Application.IReposatories
{
    public interface ICommandGenericRepo<T> where T : class
    {
        Task<T> Update(int id);
        Task<T> Remove(int id);
        Task<T> Add(T item);
    }
}
