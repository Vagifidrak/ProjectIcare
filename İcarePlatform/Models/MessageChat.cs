namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageChat")]
    public partial class MessageChat
    {
        public int id { get; set; }

        public string Text { get; set; }

        public DateTime? TimeStamp { get; set; }

        public int? RentalUserId { get; set; }

        public int? OwnerUserId { get; set; }

        [StringLength(500)]
        public string FileUrl { get; set; }
    }
}
