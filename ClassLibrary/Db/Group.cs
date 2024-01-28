using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary.Db
{
    public class Group
    {
        [Key]
        public int id { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int ReqNumUsers { get; set; }
        public List<User> Users { get; set; }
        public List<Profile> Profiles { get; set; }



    }
}
