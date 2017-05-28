using Repository.Abstracts.UnitOfWork;
using Sample.Models.Repositories.Interfaces;
using Sample.Repositories.Models;

namespace Sample.ORM
{
    public class SampleUnitOfWork : UnitOfWork
    {
        private readonly SampleContext _context;

        // repositories
        public IStudentRepository Students;

        public SampleUnitOfWork(SampleContext context): base(context)
        {
            _context = context;
            Students = new StudentRepository(_context);

        }
    }
}
