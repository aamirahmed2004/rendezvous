using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.TeamDbContext
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string? nickname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string? location { get; set; }
        List<Profile>? Profiles { get; set; }

    }
}
