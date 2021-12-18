namespace Otel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Тип номера")]
    public partial class Тип_номера
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Тип_номера()
        {
            Номер = new HashSet<Номер>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Название { get; set; }

        [Column("Количество мест")]
        public int Количество_мест { get; set; }

        public int? Стоимость { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Номер> Номер { get; set; }
    }
}
