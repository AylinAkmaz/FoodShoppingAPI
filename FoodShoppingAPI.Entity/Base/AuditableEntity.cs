using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.Base
{
    public class AuditableEntity:BaseEntity
    {
        public DateTime AddedTime { get; set; }
        public int AddedUser { get; set; }
        public string AddedIPV4Adress { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UpdatedUser { get; set; }
        public string UpdatedIPV4Adress { get; set; }


    }
}
