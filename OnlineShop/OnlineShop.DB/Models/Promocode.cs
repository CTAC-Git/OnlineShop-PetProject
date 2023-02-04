using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Db.Models
{
    public class Promocode
    {
        public Guid Id { get; set; }
        public int Discount { get; set; }
        public string Text { get; set; }
    }
}
