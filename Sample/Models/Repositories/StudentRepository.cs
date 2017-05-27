using Repository;
using Sample.Models.Entities;
using Sample.Models.Repositories.Interfaces;
using Sample.ORM;

namespace Sample.Repositories.Models
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(SampleContext context):base(context)
        {
            
        }

    }
}
