namespace DrinkStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        public int StaffID { get; set; }

        public int PersonID { get; set; }

        public decimal? Salary { get; set; }

        [Column(TypeName = "image")]
        public byte[] Avatar { get; set; }

        [Required]
        [StringLength(50)]
        public string PositionCode { get; set; }

        public virtual Cashier Cashier { get; set; }

        public virtual Manager Manager { get; set; }

        public virtual Person Person { get; set; }

        public virtual Position Position { get; set; }

        public virtual StorageManager StorageManager { get; set; }

        public virtual User User { get; set; }
    }
}
