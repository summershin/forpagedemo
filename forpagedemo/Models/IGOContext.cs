using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace forpagedemo.Models
{
    public partial class IGOContext : DbContext
    {
        public IGOContext()
        {
        }

        public IGOContext(DbContextOptions<IGOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<CollectionType> CollectionTypes { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<FeedbackManagement> FeedbackManagements { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsPhoto> ProductsPhotos { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Temp> Temps { get; set; }
        public virtual DbSet<TicketAndProduct> TicketAndProducts { get; set; }
        public virtual DbSet<TicketType> TicketTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=IGO;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(20);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.City1)
                    .HasMaxLength(20)
                    .HasColumnName("City");
            });

            modelBuilder.Entity<Collection>(entity =>
            {
                entity.ToTable("Collection");

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.CollectionTypeId).HasColumnName("CollectionTypeID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.CollectionType)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.CollectionTypeId)
                    .HasConstraintName("FK_Collection_CollectionType");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Collection_Customers");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Collection_Products");
            });

            modelBuilder.Entity<CollectionType>(entity =>
            {
                entity.ToTable("CollectionType");

                entity.Property(e => e.CollectionTypeId).HasColumnName("CollectionTypeID");

                entity.Property(e => e.CollectionType1)
                    .HasMaxLength(20)
                    .HasColumnName("CollectionType");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Coupon");

                entity.Property(e => e.CouponId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CouponID");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductIdI).HasColumnName("ProductID(i)");

                entity.Property(e => e.ProductIdIi).HasColumnName("ProductID(ii)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustumerId);

                entity.Property(e => e.CustumerId).HasColumnName("CustumerID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Birth).HasColumnType("date");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(10);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.LastName).HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(10);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.SignUpDate).HasColumnType("date");
            });

            modelBuilder.Entity<FeedbackManagement>(entity =>
            {
                entity.HasKey(e => e.FeedbackId);

                entity.ToTable("FeedbackManagement");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.FeedbackContent).HasMaxLength(250);

                entity.Property(e => e.FeedbackDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).HasMaxLength(50);

                entity.Property(e => e.ProductsId).HasColumnName("ProductsID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.FeedbackManagements)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_FeedbackManagement_Customers");

                entity.HasOne(d => d.Products)
                    .WithMany(p => p.FeedbackManagements)
                    .HasForeignKey(d => d.ProductsId)
                    .HasConstraintName("FK_FeedbackManagement_Products");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Customers");

                entity.HasOne(d => d.PayType)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PayTypeId)
                    .HasConstraintName("FK_Orders_Payment");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipperId)
                    .HasConstraintName("FK_Orders_Shipper");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Orders_Status");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailsId);

                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Products");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK_OrderDetail_TicketTypes");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PayTypeId)
                    .HasName("PK_PayType");

                entity.ToTable("Payment");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.PayType).HasMaxLength(20);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Introduction).HasMaxLength(250);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Products_City");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_Products_SubCategory");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Products_Supplier");
            });

            modelBuilder.Entity<ProductsPhoto>(entity =>
            {
                entity.HasKey(e => e.PhotoId);

                entity.ToTable("ProductsPhoto");

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductsPhotos)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductsPhoto_Products");
            });

            modelBuilder.Entity<Seat>(entity =>
            {
                entity.ToTable("Seat");

                entity.Property(e => e.SeatId).HasColumnName("SeatID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SeatName).HasMaxLength(10);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Seats)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seat_Products");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.ToTable("Shipper");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.ShipperName).HasMaxLength(30);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusName).HasMaxLength(10);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.ToTable("SubCategory");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.SubCategoryName).HasMaxLength(20);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SubCategory_Category");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(30);

                entity.Property(e => e.Phone).HasMaxLength(20);
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.ToTable("Temp");

                entity.Property(e => e.TempId).HasColumnName("TempID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Seats).HasMaxLength(100);

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.TempOrder).HasMaxLength(10);

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Temps)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Temp_Customers");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Temps)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Temp_Products");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Temps)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_Temp_SubCategory");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.Temps)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK_Temp_TicketTypes");
            });

            modelBuilder.Entity<TicketAndProduct>(entity =>
            {
                entity.ToTable("TicketAndProduct");

                entity.Property(e => e.TicketAndProductId).HasColumnName("TicketAndProductID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TicketAndProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TicketAndProduct_Products");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketAndProducts)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK_TicketAndProduct_TicketTypes");
            });

            modelBuilder.Entity<TicketType>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.TicketName).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
