using Repository.Abstracts.UnitOfWork;
using Sample.Models.Repositories.Interfaces;
using Sample.Repositories.Models;

namespace Sample.ORM
{
    public class SampleUnitOfWork : IUnitOfWork
    {
        private readonly SampleContext _context;

        // repositories
        public IStudentRepository Students;

        public SampleUnitOfWork(SampleContext context)
        {
            _context = context;
            Students = new StudentRepository(_context);

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
