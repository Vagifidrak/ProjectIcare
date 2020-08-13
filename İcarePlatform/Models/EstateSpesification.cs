namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstateSpesification")]
    public partial class EstateSpesification
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public int? EstateId { get; set; }

        public virtual Estate Estate { get; set; }
    }
}
