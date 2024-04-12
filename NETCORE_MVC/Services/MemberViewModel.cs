﻿using System.ComponentModel;

namespace NETCORE_MVC.Services
{
    public class MemberViewModel
    {
        [DisplayName("Full Name")]
        public string? FullName { get; set; }

        [DisplayName("Date Of Birth")]
        public string? DateOfBirth { get; set; }

        public string? Gender { get; set; }

        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }

        [DisplayName("Birth Place")]
        public string? BirthPlace { get; set; }
        public int Age { get; set; }
    }
}
