using System;
using System.Collections.Generic;

namespace WEB_API3.Models
{
    public partial class TblStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int RollNo { get; set; }
        public string Gender { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Department { get; set; } = null!;
    }
}
