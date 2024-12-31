using CleanArchitectureCQRs.Domain.Abstractions;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Application.Interfaces;

public interface ISpecification<T> where T : BaseEntity
{
    public Expression<Func<T, bool>> Criteria { get; set; }

    public List<Expression<Func<T, object>>> Includes { get; set; }
}
