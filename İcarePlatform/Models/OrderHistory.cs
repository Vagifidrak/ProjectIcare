namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderHistory")]
    public partial class OrderHistory
    {
        public int id { get; set; }

        public int OrderId { get; set; }

        public DateTime? OrderDate { get; set; }

        public virtual Order Order { get; set; }
    }
}
