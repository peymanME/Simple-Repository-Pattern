using Repository.Abstracts.UnitOfWork;
using Sample.Models.Repositories.Interfaces;
using System;

namespace Sample.ORM.Interfaces
{
    public interface ISampleUnitWork: IUnitOfWork, IDisposable
    {
            IStudentRepository Students { get; }
    }
}
