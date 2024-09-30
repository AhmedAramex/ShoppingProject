using CleanArchitectureCQRs.Domain.Dtos;

namespace CleanArchitectureCQRs.Application.Interfaces.Repositories;

public interface ICategoryRepository
{
    bool AddCategoy(CategoryDto category);

    bool DeleteCategoy(CategoryDto category);
    bool DeleteCategoy(Guid categoryId);
    bool UpdateCategoy(CategoryDto categoy);
}
