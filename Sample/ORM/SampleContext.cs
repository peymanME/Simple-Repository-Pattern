using System.Data.Entity;
using Sample.Models.Entities;
using Repository.DbContext;

namespace Sample.ORM
{
    public  class SampleContext: RepContext
    {
        public SampleContext()
            : base("name=ORM")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                        .HasMany<Course>(s => s.Courses)
                        .WithMany(c => c.Students)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("Courses_Students_Id");
                            cs.MapRightKey("Students_Courses_Id");
                            cs.ToTable("Student_Course");
                        });

        }
    }
}
