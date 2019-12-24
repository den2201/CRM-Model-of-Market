using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    class Check
    {
        public int CheckID { get; set; }

        public DateTime date { get; set; }

        /// <summary>
        /// создаем поля для связей 1 ко многим
        /// </summary>
        public int CustomerID { get; set; }
        public virtual Customer Costumer { get; set; }

        public ICollection<Sell> Sells { get; set; }

        public int SellerID { get; set; }
        public virtual Seller Seller { get; set; }
        public override string ToString()
        {
            return $"№ {CheckID} Date {date.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
