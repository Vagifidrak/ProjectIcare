namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Photo
    {
        public int id { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        public int? UserId { get; set; }
    }
}
