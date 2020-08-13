namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ContractType { get; set; }

        [StringLength(250)]
        public string ContractLink { get; set; }

        public int? EstateId { get; set; }

        [StringLength(128)]
        public string RentalId { get; set; }

        public DateTime ContractDeadline { get; set; }

        public DateTime SignContract { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public decimal RentPrice { get; set; }

        public virtual Estate Estate { get; set; }
    }
}
