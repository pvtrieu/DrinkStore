namespace DrinkStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Import")]
    public partial class Import
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImportID { get; set; }

        public int CashierID { get; set; }

        public int ProductID { get; set; }

        public int SupplierID { get; set; }

        public int? ImportQuant { get; set; }

        public int? CurrentUnitQuant { get; set; }

        public int? CurrentBoxQuant { get; set; }

        public decimal? WholeCost { get; set; }

        public decimal? RetailCost { get; set; }

        public DateTime? ImportDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public virtual Cashier Cashier { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
