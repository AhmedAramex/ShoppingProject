using CleanArchitectureCQRs.Application.Models;
using CleanArchitectureCQRs.Domain.Abstractions;
using CleanArchitectureCQRs.Domain.Entites;

namespace CleanArchitectureCQRs.Application.Interfaces;

public interface Isorting<T> where T : BaseEntity
{
    Task<IQueryable<Product>> sorting(string sortBy);

    //Task<List<T>> Filtering(FilterBy filterBy, ISpecification<T> spec);
}
