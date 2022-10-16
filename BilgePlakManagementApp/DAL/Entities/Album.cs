using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Entities
{
    public class Album : BaseProduct 
    {
        public int AuthorId { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string? AlbumName { get; set; }

        //public int? CategoryId { get; set; }

        //public virtual Category Category { get; set; }


    }
}
