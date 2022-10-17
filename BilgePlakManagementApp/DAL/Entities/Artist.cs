using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Entities
{
    public class Artist
    {
        public Artist()
        {
           this.Albums = new List<Album>();
        }
        public int ArtistId { get; set; }

        public string? ArtistName { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public List<Album> Albums { get; set; }

    }
}
