using Repository.Abstracts.GenericEntity;
using System.Collections.Generic;

namespace Sample.Models.Entities
{
    public class Student: EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Number { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
