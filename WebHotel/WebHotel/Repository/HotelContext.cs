using Microsoft.EntityFrameworkCore;
using WebHotel.Models;

namespace WebHotel
{
    public partial class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Бронирование_номеров> Бронирование_номеров { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Номер> Номер { get; set; }
        public virtual DbSet<Сотрудник> Сотрудник { get; set; }
        public virtual DbSet<Тип_номера> Тип_номера { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Клиент>().ToTable("Клиент");

            modelBuilder.Entity<Номер>().ToTable("Номер");

            modelBuilder.Entity<Сотрудник>().ToTable("Сотрудник");

            modelBuilder.Entity<Тип_номера>().ToTable("Тип_номера");
        }
    }
}
