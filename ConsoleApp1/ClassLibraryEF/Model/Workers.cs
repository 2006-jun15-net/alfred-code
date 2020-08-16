using System;
using System.Collections.Generic;

namespace ClassLibraryEF.Model
{
    public partial class Workers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ssn { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
    }
}
