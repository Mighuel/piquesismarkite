namespace MvcPiqueSysMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        public int ID { get; set; }

        [Column("E-MAIL")]
        [Required]
        [StringLength(80)]
        public string E_MAIL { get; set; }

        [Required]
        [StringLength(30)]
        public string SENHA { get; set; }
    }
}
