using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Entities
{
    public interface IEntity<T>
    {
        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        List<T> GetAll();

        T GetById(int id);




    }
}
