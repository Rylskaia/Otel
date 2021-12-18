namespace Otel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Номер
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Номер()
        {
            Бронирование_номеров = new HashSet<Бронирование_номеров>();
        }

        [Key]
        [Column("Номер")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер1 { get; set; }

        public int Комплектация { get; set; }

        public byte[] Фото { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Бронирование_номеров> Бронирование_номеров { get; set; }

        public virtual Тип_номера Тип_номера { get; set; }
    }
}
