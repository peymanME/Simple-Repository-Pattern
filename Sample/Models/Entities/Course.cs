using Repository.Abstracts.GenericEntity;
using System;
using System.Collections.Generic;

namespace Sample.Models.Entities
{
    public class Course :EntityBase
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
