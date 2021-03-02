namespace SisPortaria.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("techinsyscurso02.visitas")]
    public partial class visitas
    {
        public int ID { get; set; }

        public int? IDPESSOA { get; set; }

        [StringLength(100)]
        public string HR_ENTRADA { get; set; }

        [StringLength(100)]
        public string HR_SAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ANDAMENTO { get; set; }

        [StringLength(200)]
        public string LOCAL_VISITA { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        [StringLength(1000)]
        public string MOTIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DELETADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        public virtual pessoa pessoa { get; set; }
    }
}
