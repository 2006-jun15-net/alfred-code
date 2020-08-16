using System;
using System.Collections.Generic;

namespace ClassLibraryEF.Model
{
    public partial class Department
    {
        public Department()
        {
            Workers = new HashSet<Workers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Workers> Workers { get; set; }
    }
}
