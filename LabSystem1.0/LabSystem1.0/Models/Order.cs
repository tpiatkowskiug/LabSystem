using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabSystem1._0.Models
{
    public class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [Display(Name = "Ilość prób")]
        public int QuantitySample { get; set; }

        [Display(Name = "Oznakowanie prób")]
        [DataType(DataType.MultilineText)]
        public string MarkingSample { get; set; }

        [Display(Name = "Wybór rodzaju badań")]
        public int? PriceListId { get; set; }

        [Display(Name = "Cena razem")]
        public float? PriceOrder { get; set; }

        [Display(Name = "Data zlecenia")]
        [UIHint("DataTimePicker")]            //dynamiczny helper
        public DateTime OrderCreationDate { get; set; }

        [Display(Name = "Wprowadził zlecenie")]
        public int? EmployeeId { get; set; }

        [Display(Name = "Wyniki wysłać na adres: ")]
        public int? CustomerId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual PriceList PriceList { get; set; }

    }
}