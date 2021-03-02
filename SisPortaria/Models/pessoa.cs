namespace SisPortaria.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("techinsyscurso02.pessoa")]
    public partial class pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pessoa()
        {
            visitas = new HashSet<visitas>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(20)]
        public string SEXO { get; set; }

        public int? IDADE { get; set; }

        [StringLength(100)]
        public string DT_NASCIMENTO { get; set; }

        [StringLength(100)]
        public string ENDERECO { get; set; }

        [StringLength(20)]
        public string CPF { get; set; }

        [StringLength(20)]
        public string RG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DELETADO { get; set; }

        public int? NUMERO_CA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<visitas> visitas { get; set; }
    }
}
