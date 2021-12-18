namespace WebHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудник
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудник()
        {
            Бронирование_номеров = new HashSet<Бронирование_номеров>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ФИО { get; set; }

        [StringLength(40)]
        public string Адрес { get; set; }

        [StringLength(11)]
        public string Телефон { get; set; }

        [Required]
        [StringLength(15)]
        public string Должность { get; set; }

        [Column("Заработная плата", TypeName = "money")]
        public decimal Заработная_плата { get; set; }

        [Required]
        [StringLength(30)]
        public string Логин { get; set; }

        [Required]
        [StringLength(30)]
        public string Пароль { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Бронирование_номеров> Бронирование_номеров { get; set; }
    }
}
