using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Db
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string? Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly BDate { get; set; }
        public string? Location { get; set; }
        List<Profile>? Profiles { get; set; }

    }
}
