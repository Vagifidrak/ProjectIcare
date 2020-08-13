namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderHistories = new HashSet<OrderHistory>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        public int? CustomerId { get; set; }

        [StringLength(150)]
        public string CustomerFullName { get; set; }

        [StringLength(15)]
        public string CustomerPhone { get; set; }

        public bool? IsGuestOrder { get; set; }

        public int? PromoId { get; set; }

        public DateTime PlacedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
