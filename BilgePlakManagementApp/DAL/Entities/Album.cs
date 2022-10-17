using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Entities
{
    public class Album
    {
        public int ProductId { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? AlbumName { get; set; }

        public float? Discount { get; set; }

        public string? ProductCode { get; set; }

        public decimal? Price { get; set; }

        public int? UnitsInStock { get; set; }

        public int? CriticalLevel { get; set; }

        public bool? Discontinued { get; set; }       

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public int? ArtistId { get; set; }

        public Artist Artist { get; set; }
        
    }
}
