namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactMe")]
    public partial class ContactMe
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Office { get; set; }

        [StringLength(19)]
        public string Number { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(300)]
        public string ImgUrl { get; set; }

        [Required]
        [StringLength(300)]
        public string ImgIcon { get; set; }
    }
}
