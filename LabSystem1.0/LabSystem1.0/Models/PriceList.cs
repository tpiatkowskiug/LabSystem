using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabSystem1._0.Models
{
    public class PriceList
    {
        [ScaffoldColumn(false)]
        public int PriceListId { get; set; }
        public string TypeOfResearch { get; set; }
        public float PriceNetto { get; set; }
        public float PriceBrutto { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}