using CleanArchitecture.Domain.Repositories;

namespace CleanArchitecture.Infra.Repositories;

public class UnitOfWork : IUnitOfWork
{
    //private readonly ApplicationDbContext _context;
    
    // public UnitOfWork(ApplicationDbContext context)
    // {
    //     //_context = context;
    // }
    
    public Task Commit(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
        // await _context.SaveChangesAsync(cancellationToken);
    }
}