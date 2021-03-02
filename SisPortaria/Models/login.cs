namespace SisPortaria.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("techinsyscurso02.login")]
    public partial class login
    {
        public int ID { get; set; }

        [Column("LOGIN")]
        [StringLength(100)]
        public string LOGIN1 { get; set; }

        [StringLength(100)]
        public string SENHA { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DELETADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ADMIN { get; set; }
    }
}
