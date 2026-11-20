using Microsoft.EntityFrameworkCore;
using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL;

public class HotelDbContext : DbContext
{
    string _cs;
    public HotelDbContext(string cs)
    {
        _cs = cs;
    }
   
    public DbSet<Guest> Guests => Set<Guest>();
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Reservation> Reservations=> Set<Reservation>();
    public DbSet<UserAccount> UserAccounts => Set<UserAccount>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasOne(r => r.Guest)
            .WithMany(g => g.Reservations)
            .HasForeignKey(r => r.GuestId);

            entity.HasOne(r => r.Room)
            .WithMany(rm => rm.Reservations)
            .HasForeignKey(r => r.RoomId);

            entity.Property(r=>r.DateIn)
            .HasColumnType("datetime2(0)");
            entity.Property(r=>r.DateOut)
            .HasColumnType("datetime2(0)");

        });
            
            
        modelBuilder.Entity<Guest>(entity =>
        {
            entity.ToTable("Guests");
            entity.Property(g => g.FirstName)
            .HasMaxLength(32)
            .IsRequired(true);
            entity.Property(g => g.LastName)
            .HasMaxLength(50)
            .IsRequired(true);
            entity.Property(g=>g.NationalCode)
            .HasMaxLength(10)
            .IsFixedLength()
            .IsUnicode(false)
            .IsRequired(true);

            entity.Property(g => g.MobileNumber)
                  .HasMaxLength(11)
                  .IsUnicode(false)
                  .IsRequired(true);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.Property(u => u.FirstName)
            .HasMaxLength(32)
            .IsRequired(true);

            entity.Property(u=>u.LastName)
            .HasMaxLength (50)
            .IsRequired (true);

            entity.Property(u => u.UserName)
            .HasMaxLength(30)
            .IsUnicode (true)
            .IsRequired(true);

            entity.Property(u => u.PasswordHash)
            .HasMaxLength(255)
            .IsUnicode (false)
            .IsRequired(true);

            entity.Property(u => u.MobileNumber)
            .HasMaxLength(11)
            .IsUnicode(false)
            .IsRequired(true);

            entity.HasIndex(u => u.UserName)
            .IsUnique();
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasIndex(r => r.RoomNumber)
            .IsUnique();
            entity.ToTable("Rooms", table =>
            {
                table.HasCheckConstraint(
                    "CK_Rooms_Capacity",
                    "[Capacity]>0"
                    );
                table.HasCheckConstraint(
                    "CK_Rooms_Price",
                    "[Price]>=0"
                    );
                table.HasCheckConstraint(
                    "CK_Rooms_RoomNumber",
                    "[RoomNumber]>=0"
                    );
            });
            entity.Property(r=>r.Price)
            .HasPrecision(18,2)
            .IsRequired();
            entity.Property(r => r.Capacity)
            .IsRequired();
            entity.Property(r => r.RoomNumber)
            .IsRequired();
        });
        
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_cs);
        base.OnConfiguring(optionsBuilder);
    }
}
