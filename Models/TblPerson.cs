using System;
using System.Collections.Generic;

namespace WEB_API3.Models
{
    public partial class TblPerson
    {
        internal string gender;
        internal int id;

        public int RollNo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? Department { get; set; }
        public decimal? Fees { get; set; }
        public string? Status { get; set; }
    }
}
