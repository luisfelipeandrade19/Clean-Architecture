using Domain.Interfaces;
using Persistence.Context;

namespace Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task Commit(CancellationToken cancellationToken)
    {
       await _context.SaveChangesAsync(cancellationToken);
    }
}