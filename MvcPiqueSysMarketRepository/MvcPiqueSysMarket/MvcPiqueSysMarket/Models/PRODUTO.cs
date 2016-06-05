namespace MvcPiqueSysMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUTO")]
    public partial class PRODUTO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME { get; set; }

        [Required]
        [StringLength(150)]
        public string DESCRICAO { get; set; }

        [Required]
        [StringLength(15)]
        public string PRECO { get; set; }
    }
}
