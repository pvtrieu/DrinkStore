namespace DrinkStore.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DSModel : DbContext
    {
        public DSModel()
            : base("name=DSModel")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Cashier> Cashiers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<StorageManager> StorageManagers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cashier>()
                .HasMany(e => e.Imports)
                .WithRequired(e => e.Cashier)
                .HasForeignKey(e => e.CashierID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cashier>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Cashier)
                .HasForeignKey(e => e.CashierID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Import>()
                .Property(e => e.WholeCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Import>()
                .Property(e => e.RetailCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalSale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalProfit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Sale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Profit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Person>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Staffs)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.PositionCode)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Staffs)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.WholeSale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.RetailSale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Imports)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Staff>()
                .Property(e => e.PositionCode)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasOptional(e => e.Cashier)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Staff>()
                .HasOptional(e => e.Manager)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Staff>()
                .HasOptional(e => e.StorageManager)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Staff>()
                .HasOptional(e => e.User)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Imports)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
