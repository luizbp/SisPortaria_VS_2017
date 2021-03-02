namespace SisPortaria.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("techinsyscurso02.verificacao")]
    public partial class verificacao
    {
        public int ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string P_LOGIN { get; set; }
    }
}
