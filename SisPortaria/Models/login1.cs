namespace SisPortaria.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("techinsyscurso02.login1")]
    public partial class login1
    {
        public int id { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(30)]
        public string senha { get; set; }
    }
}
