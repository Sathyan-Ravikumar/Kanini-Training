using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TableResevationforRestaurant.Models;

public partial class TableReseravtionContext : DbContext
{
    public TableReseravtionContext()
    {
    }

    public TableReseravtionContext(DbContextOptions<TableReseravtionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }

    public virtual DbSet<FoodCategory> FoodCategories { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ReservationDetail> ReservationDetails { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TableAvailability> TableAvailabilities { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerDetail>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__8CB382B13D4BAF33");

            entity.ToTable("Customer_Details");

            entity.Property(e => e.CustomerId).HasColumnName("Customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(30)
                .HasColumnName("Customer_name");
            entity.Property(e => e.MobileNumber).HasColumnName("mobile_number");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.CustomerDetails)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("FK__Customer___useri__4BAC3F29");
        });

        modelBuilder.Entity<FoodCategory>(entity =>
        {
            entity.HasKey(e => e.Categoryid).HasName("PK__food_cat__23CDE5901C0B8D7B");

            entity.ToTable("food_category");

            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.CategoryTypes)
                .HasMaxLength(15)
                .HasColumnName("Category_types");

            entity.HasOne(d => d.Hotel).WithMany(p => p.FoodCategories)
                .HasForeignKey(d => d.Hotelid)
                .HasConstraintName("FK__food_cate__Hotel__59063A47");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.Hotelid).HasName("PK__Hotels__46033FE7C4600EFD");

            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Facebook)
                .HasMaxLength(40)
                .HasColumnName("facebook");
            entity.Property(e => e.HotelName)
                .HasMaxLength(15)
                .HasColumnName("Hotel_name");
            entity.Property(e => e.Hotelnumber).HasColumnName("hotelnumber");
            entity.Property(e => e.Instalink)
                .HasMaxLength(40)
                .HasColumnName("instalink");
            entity.Property(e => e.Youtube)
                .HasMaxLength(40)
                .HasColumnName("youtube");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Productid).HasName("PK__product__2D172D32D6760373");

            entity.ToTable("product");

            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Cost)
                .HasColumnType("money")
                .HasColumnName("cost");
            entity.Property(e => e.Dishname).HasMaxLength(25);
            entity.Property(e => e.Images).HasColumnName("images");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.Categoryid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__product__categor__5BE2A6F2");
        });

        modelBuilder.Entity<ReservationDetail>(entity =>
        {
            entity.HasKey(e => e.Reserveid).HasName("PK__reservat__4A3465AD6ED4600D");

            entity.ToTable("reservation_details");

            entity.Property(e => e.Reserveid).HasColumnName("reserveid");
            entity.Property(e => e.CustomerId).HasColumnName("Customer_id");
            entity.Property(e => e.NumberOfPeople).HasColumnName("Number_of_people");
            entity.Property(e => e.ReserveDate)
                .HasColumnType("date")
                .HasColumnName("reserve_date");
            entity.Property(e => e.Slot)
                .HasMaxLength(15)
                .HasColumnName("slot");
            entity.Property(e => e.TableId).HasColumnName("table_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.ReservationDetails)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__reservati__Custo__5535A963");

            entity.HasOne(d => d.Table).WithMany(p => p.ReservationDetails)
                .HasForeignKey(d => d.TableId)
                .HasConstraintName("FK__reservati__table__5629CD9C");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.TableId).HasName("PK__Tables__B21E8F241B7FD86E");

            entity.Property(e => e.TableId).HasColumnName("table_id");
            entity.Property(e => e.SeatingCapacity).HasColumnName("Seating_capacity");
            entity.Property(e => e.Slot)
                .HasMaxLength(15)
                .HasColumnName("slot");
            entity.Property(e => e.TableNumber).HasColumnName("table_number");

            entity.HasOne(d => d.Hotel).WithMany(p => p.Tables)
                .HasForeignKey(d => d.Hotelid)
                .HasConstraintName("FK__Tables__Hotelid__5070F446");
        });

        modelBuilder.Entity<TableAvailability>(entity =>
        {
            entity.HasKey(e => e.AvailabilityId).HasName("PK__Table_av__86E3A8013339F7DD");

            entity.ToTable("Table_availability");

            entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");
            entity.Property(e => e.AvailableDate)
                .HasColumnType("date")
                .HasColumnName("available_date");
            entity.Property(e => e.DinnerSlot)
                .HasMaxLength(20)
                .HasColumnName("Dinner_slot");
            entity.Property(e => e.LunchSlot)
                .HasMaxLength(20)
                .HasColumnName("Lunch_slot");
            entity.Property(e => e.TableId).HasColumnName("table_id");

            entity.HasOne(d => d.Table).WithMany(p => p.TableAvailabilities)
                .HasForeignKey(d => d.TableId)
                .HasConstraintName("FK__Table_ava__table__52593CB8");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__users__CBA1B25770EFFE27");

            entity.ToTable("users");

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .HasColumnName("password");
            entity.Property(e => e.Role).HasMaxLength(15);
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
