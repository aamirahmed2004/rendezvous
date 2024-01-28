using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Db
{
    public class Image
    {
        [Key]
        public int id { get; set; }
        public byte[] Img { get; set; }
    }
}
