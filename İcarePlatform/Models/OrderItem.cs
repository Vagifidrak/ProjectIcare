namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderItem")]
    public partial class OrderItem
    {
        public int id { get; set; }

        public int? OrderId { get; set; }

        public int? PayTypeId { get; set; }

        public decimal? Price { get; set; }

        public virtual Order Order { get; set; }

        public virtual PayType PayType { get; set; }
    }
}
