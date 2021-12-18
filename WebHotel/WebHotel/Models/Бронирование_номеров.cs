namespace WebHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Бронирование номеров")]
    public partial class Бронирование_номеров
    {
        [Key]
        [Column("Номер заявки")]
        public int Номер_заявки { get; set; }

        [Column("ID Клиента")]
        public int ID_Клиента { get; set; }

        public int Номер { get; set; }

        [Column("ID Сотрудника")]
        public int? ID_Сотрудника { get; set; }

        [Column("Дата заселения", TypeName = "date")]
        public DateTime Дата_заселения { get; set; }

        [Column("Дата Выезда", TypeName = "date")]
        public DateTime Дата_Выезда { get; set; }

        [StringLength(5)]
        public string Завтрак { get; set; }

        [StringLength(15)]
        public string Статус { get; set; }

        public virtual Клиент Клиент { get; set; }

        public virtual Сотрудник Сотрудник { get; set; }

        public virtual Номер Номер1 { get; set; }
    }
}
