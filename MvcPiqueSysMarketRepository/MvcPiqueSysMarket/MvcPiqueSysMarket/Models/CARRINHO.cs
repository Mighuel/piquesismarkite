namespace MvcPiqueSysMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARRINHO")]
    public partial class CARRINHO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_PRODUTO { get; set; }

        [Required]
        [StringLength(150)]
        public string ID_USUARIO { get; set; }
    }
}
