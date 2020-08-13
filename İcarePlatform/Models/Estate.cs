namespace İcarePlatform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estate")]
    public partial class Estate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estate()
        {
            Contracts = new HashSet<Contract>();
            EstateImages = new HashSet<EstateImage>();
            EstateSpesifications = new HashSet<EstateSpesification>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string EstateCode { get; set; }

        [Required]
        [StringLength(128)]
        public string UserOwnerId { get; set; }

        [StringLength(100)]
        public string YourAddress { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstateImage> EstateImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstateSpesification> EstateSpesifications { get; set; }
    }
}
