using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Author:BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        
        public int BiographyId { get; set; }
        public  Biography Biography { get; set; } = null!;
    }
}
