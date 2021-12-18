using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Otel
{
    public partial class HotelContext : DbContext
    {
        public HotelContext()
            : base("name=ContextHotel")
        {
        }

        public virtual DbSet<Бронирование_номеров> Бронирование_номеров { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Номер> Номер { get; set; }
        public virtual DbSet<Сотрудник> Сотрудник { get; set; }
        public virtual DbSet<Тип_номера> Тип_номера { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Клиент>()
                .HasMany(e => e.Бронирование_номеров)
                .WithRequired(e => e.Клиент)
                .HasForeignKey(e => e.ID_Клиента)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Номер>()
                .HasMany(e => e.Бронирование_номеров)
                .WithRequired(e => e.Номер1)
                .HasForeignKey(e => e.Номер)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .Property(e => e.Заработная_плата)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Бронирование_номеров)
                .WithOptional(e => e.Сотрудник)
                .HasForeignKey(e => e.ID_Сотрудника);

            modelBuilder.Entity<Тип_номера>()
                .HasMany(e => e.Номер)
                .WithRequired(e => e.Тип_номера)
                .HasForeignKey(e => e.Комплектация)
                .WillCascadeOnDelete(false);
        }
    }
}
