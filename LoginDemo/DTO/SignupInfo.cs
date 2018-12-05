using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginDemo.DTO
{
    public class SignupInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Skills { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Certification { get; set; }
        public string UserType { get; set; }
    }
}