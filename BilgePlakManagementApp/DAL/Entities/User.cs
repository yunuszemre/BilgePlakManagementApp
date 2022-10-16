using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Entities
{
    public class User : IEntity
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
