using Repository.DbContext;

namespace Repository.Abstracts.UnitOfWork
{
    public abstract class UnitOfWork : IUnitOfWork
    {
        private readonly RepContext _context;

        public UnitOfWork(RepContext context)
        {
            _context = context;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
