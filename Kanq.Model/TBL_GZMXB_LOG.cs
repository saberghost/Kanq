namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_GZMXB_LOG")]
    public partial class TBL_GZMXB_LOG
    {
        public decimal ID { get; set; }

        [StringLength(20)]
        public string MID { get; set; }

        public DateTime? ZXSJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? BYXZJBGZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? BYXZGWGZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? JBGZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? GWGZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HSBZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? JTBZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HJ { get; set; }

        [StringLength(200)]
        public string BZ { get; set; }

        [StringLength(50)]
        public string XM { get; set; }
    }
}
