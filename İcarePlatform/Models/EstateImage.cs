namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstateImage")]
    public partial class EstateImage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Url { get; set; }

        public int EstateId { get; set; }

        public virtual Estate Estate { get; set; }
    }
}
