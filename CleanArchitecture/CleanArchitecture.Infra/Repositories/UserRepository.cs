using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;

namespace CleanArchitecture.Infra.Repositories;

public class UserRepository : IUserRepository
{
    // public UserRepository(CatalogoContext context)
    // {
    //     _context = context;
    // }
    
    public IUnitOfWork UnitOfWork { get; } = new UnitOfWork(); //= context;
    
    public void Create(User entity)
    {
        throw new NotImplementedException();
    }

    public void Update(User entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAll(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }



    public Task<User> GetByEmail(string email, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task Commit(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}