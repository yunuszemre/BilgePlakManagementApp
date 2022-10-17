using BilgePlakManagementApp.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Entities
{
    public class User : IEntity<User>
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        

        List<User> IEntity<User>.GetAll()
        {
            using (PlakDbContext dbContext = new PlakDbContext())
            {
                return dbContext.Users.ToList();
            }
        }

       

        User IEntity<User>.GetById(int id)
        {
            using (PlakDbContext dbContext = new PlakDbContext())
            {
                return dbContext.Users.FirstOrDefault(t0 => t0.UserId == id);
            }
        }
    }
}
