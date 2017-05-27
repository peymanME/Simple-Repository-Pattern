namespace Repository.DbContext
{
    using System.Data.Entity;

    public class RepContext : DbContext
    {
         public RepContext(string ConnectionName)
            : base(ConnectionName)
        {
        }

     }
}