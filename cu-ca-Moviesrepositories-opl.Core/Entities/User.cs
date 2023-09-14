using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_MovieShop_opl_Afst_Core.Entities
{
    public class User : BaseEntity
    {
        public  string Username { get; set; }
        public  string Firstname { get; set; }
        public  string Lastname{ get; set; }
        //many ratings
        public ICollection<Rating> Ratings { get; set; }
    }

}
