using BilgePlakManagementApp.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Entities
{
    public class Category
    {
        public Category()
        {
            this.Albums = new List<Album>();
            
        }
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public List<Album> Albums { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        
    }
}
