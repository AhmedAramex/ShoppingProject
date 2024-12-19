using CleanArchitectureCQRs.Domain.Entites;

namespace CleanArchitectureCQRs.Application.Interfaces;

public interface Isorting
{
     Task<IQueryable<Product>> sorting(string sortBy);
}
