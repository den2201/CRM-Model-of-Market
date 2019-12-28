using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
  public  class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// связь 1 ко многим 
        /// </summary>
        public virtual ICollection<Check> checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
