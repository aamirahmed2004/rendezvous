using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.TeamDbContext
{
    public class InterestTag
    {
        [Key]
        public int id { get; set; }
        public string Tag { get; set; }
    }
}
