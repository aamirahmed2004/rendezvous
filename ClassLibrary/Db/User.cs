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
        public DateTime BDate { get; set; }
        public string? Location { get; set; }
        List<Profile>? Profiles { get; set; }

        public int GetAge()
        {
            DateTime now = DateTime.Today;
            DateTime bday = BDate;
            int age = now.Year - BDate.Year;
            if (now < bday)
                age--;
            return age;
        }

    }
}
