﻿using System;
using System.Collections.Generic;

namespace ClassLibraryEF.Model
{
    public partial class EmployeeDetails
    {
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? Salary { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual Workers Employee { get; set; }
    }
}
