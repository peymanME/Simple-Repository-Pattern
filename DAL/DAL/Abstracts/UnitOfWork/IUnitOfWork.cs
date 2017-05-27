using System;

namespace Repository.Abstracts.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        int Complete();
    }
}
