using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_MovieShop_opl_Afst_Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        //many movies
        public ICollection<Movie> Movies { get; set; }
    }
}
