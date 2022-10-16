using BilgePlakManagementApp.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Entities
{
    public class Category:IEntity<Category>
    {
        public Category()
        {
            this.Products = new List<BaseProduct>();
            //this.Albums = new List<Album>();
        }
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        //public virtual List<Album> Albums { get; set; }

        public List<BaseProduct> Products { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public List<Category> GetAll()
        {
            using(PlakDbContext dbContext = new PlakDbContext())
            {
                return dbContext.Categories.ToList();                
            }
        }

        public Category GetById(int id)
        {
            using (PlakDbContext dbContext = new PlakDbContext())
            {
                return dbContext.Categories.FirstOrDefault(t0 => t0.CategoryId == id);
            }
        }
    }
}
