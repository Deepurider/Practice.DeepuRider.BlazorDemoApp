using Microsoft.EntityFrameworkCore;
using Practice.DeepuRider.Application.Interfaces;
using Practice.DeepuRider.Domain.Data;
using Practice.DeepuRider.Domain.Models;

namespace Practice.DeepuRider.Application.Services
{
    public class UserService : IUserService
    {
        private readonly BlazorDomainContext _context;

        public UserService(BlazorDomainContext context)
        {
            _context = context;
        }

        public async Task<User> Create(User user, CancellationToken cancellationToken)
        {
            await _context.AddAsync(user, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return user;
        }

        public async Task<User?> GetAsync(int userId, CancellationToken cancellationToken)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserId == userId, cancellationToken);
        }

        public async Task<IQueryable<User>> GetListAsync(CancellationToken cancellationToken)
        {
            return _context.Users.AsQueryable();
        }
    }
}
