using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Biography:BaseEntity
    {
        public string BiographyData { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = null!;
        public string Nationality { get; set; } = null!;

        
        public int AuthorId { get; set; }
        public  Author Author { get; set; } = null!;
    }
}
