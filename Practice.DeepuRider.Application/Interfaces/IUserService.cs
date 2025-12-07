using Practice.DeepuRider.Domain.Models;

namespace Practice.DeepuRider.Application.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetAsync(int userId, CancellationToken cancellationToken);
        Task<IQueryable<User>> GetListAsync(CancellationToken cancellationToken);
        Task<User> Create(User user, CancellationToken cancellationToken);
    }
}
