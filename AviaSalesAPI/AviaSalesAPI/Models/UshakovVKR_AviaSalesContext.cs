using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AviaSalesAPI.Models
{
    public partial class UshakovVKR_AviaSalesContext : DbContext
    {
        public UshakovVKR_AviaSalesContext()
        {
        }

        public UshakovVKR_AviaSalesContext(DbContextOptions<UshakovVKR_AviaSalesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Destination> Destinations { get; set; } = null!;
        public virtual DbSet<FlightDatum> FlightData { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<PassportType> PassportTypes { get; set; } = null!;
        public virtual DbSet<Pricecheck> Pricechecks { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<TicketType> TicketTypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MOFV5H4\\VAILACESQL;Database=UshakovVKR_AviaSales;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.IdCity);

                entity.ToTable("City");

                entity.Property(e => e.IdCity).HasColumnName("idCity");

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Country");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.ToTable("Client");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GenderCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.IntPassportType).HasColumnName("intPassportType");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.GenderCodeNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.GenderCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_Gender");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_Client_User");

                entity.HasOne(d => d.IntPassportTypeNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IntPassportType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_PassportType");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.IdCompany);

                entity.ToTable("Company");

                entity.Property(e => e.IdCompany).HasColumnName("idCompany");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Designator).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.IdCountry)
                    .HasName("PK__Country__8536480924272497");

                entity.ToTable("Country");

                entity.Property(e => e.IdCountry)
                    .ValueGeneratedNever()
                    .HasColumnName("idCountry");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.HasKey(e => e.IdDestination);

                entity.ToTable("Destination");

                entity.Property(e => e.IdDestination).HasColumnName("idDestination");

                entity.Property(e => e.Aeroport).HasMaxLength(50);

                entity.Property(e => e.IdCity).HasColumnName("idCity");

                entity.Property(e => e.Lat).HasColumnType("decimal(23, 13)");

                entity.Property(e => e.Long).HasColumnType("decimal(23, 13)");

                entity.Property(e => e.TimeZone).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Destinations)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Destination_City");
            });

            modelBuilder.Entity<FlightDatum>(entity =>
            {
                entity.HasKey(e => e.IdFlight);

                entity.Property(e => e.IdFlight).HasColumnName("idFlight");

                entity.Property(e => e.BuisinessPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DateFlightEnd).HasColumnType("datetime");

                entity.Property(e => e.DateOfFlight).HasColumnType("datetime");

                entity.Property(e => e.EconomPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IdCompany).HasColumnName("idCompany");

                entity.Property(e => e.IdDestination).HasColumnName("idDestination");

                entity.Property(e => e.IdDestinationFrom).HasColumnName("idDestinationFrom");

                entity.Property(e => e.IsCanceled).HasColumnName("isCanceled");

                entity.Property(e => e.PlaneNumber).HasMaxLength(100);

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.FlightData)
                    .HasForeignKey(d => d.IdCompany)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightData_Company");

                entity.HasOne(d => d.IdDestinationNavigation)
                    .WithMany(p => p.FlightDatumIdDestinationNavigations)
                    .HasForeignKey(d => d.IdDestination)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightData_Destination");

                entity.HasOne(d => d.IdDestinationFromNavigation)
                    .WithMany(p => p.FlightDatumIdDestinationFromNavigations)
                    .HasForeignKey(d => d.IdDestinationFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightData_Destination1");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Gender");

                entity.Property(e => e.Code)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.IdNotification);

                entity.Property(e => e.IdNotification).HasColumnName("idNotification");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(500);

                entity.Property(e => e.DateOfNotifying).HasColumnType("datetime");

                entity.Property(e => e.DateSet).HasColumnType("datetime");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdPriceCheck).HasColumnName("idPriceCheck");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifications_Client");

                entity.HasOne(d => d.IdPriceCheckNavigation)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.IdPriceCheck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifications_Pricecheck");
            });

            modelBuilder.Entity<PassportType>(entity =>
            {
                entity.HasKey(e => e.IdPassportType);

                entity.ToTable("PassportType");

                entity.Property(e => e.IdPassportType)
                    .ValueGeneratedNever()
                    .HasColumnName("idPassportType");

                entity.Property(e => e.PassportType1)
                    .HasMaxLength(50)
                    .HasColumnName("PassportType");
            });

            modelBuilder.Entity<Pricecheck>(entity =>
            {
                entity.HasKey(e => e.IdPriceCheck);

                entity.ToTable("Pricecheck");

                entity.Property(e => e.IdPriceCheck).HasColumnName("idPriceCheck");

                entity.Property(e => e.PriceAction).HasMaxLength(10);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("Role");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("idRole");

                entity.Property(e => e.RoleName).HasMaxLength(25);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.IdTicket);

                entity.ToTable("Ticket");

                entity.Property(e => e.IdTicket).HasColumnName("idTicket");

                entity.Property(e => e.DateOfPurchase).HasColumnType("datetime");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdFlight).HasColumnName("idFlight");

                entity.Property(e => e.IdTicketType).HasColumnName("idTicketType");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Client");

                entity.HasOne(d => d.IdFlightNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdFlight)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_FlightData");

                entity.HasOne(d => d.IdTicketTypeNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdTicketType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_TicketType");
            });

            modelBuilder.Entity<TicketType>(entity =>
            {
                entity.HasKey(e => e.IdTicketType);

                entity.ToTable("TicketType");

                entity.Property(e => e.IdTicketType)
                    .ValueGeneratedNever()
                    .HasColumnName("idTicketType");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.IdRole).HasColumnName("idRole");

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
