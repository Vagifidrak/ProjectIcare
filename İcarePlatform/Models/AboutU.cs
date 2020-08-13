namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AboutU
    {
        public int Id { get; set; }

        public string description { get; set; }

        public string UrlImg { get; set; }

        [StringLength(250)]
        public string header { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }
    }
}
