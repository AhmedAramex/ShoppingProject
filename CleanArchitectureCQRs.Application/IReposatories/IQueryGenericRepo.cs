using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Application.IReposatories;

public interface IQueryGenericRepo<T> where T : class
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    //Task<T> GetByIdWithIncludesAsync(int id);

}
