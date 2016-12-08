namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_GZMXB")]
    public partial class TBL_GZMXB
    {
        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(50)]
        public string XM { get; set; }

        [StringLength(50)]
        public string XB { get; set; }

        [StringLength(50)]
        public string WHCD { get; set; }

        [StringLength(50)]
        public string BYXX { get; set; }

        [StringLength(50)]
        public string ZY { get; set; }

        [StringLength(50)]
        public string XLLB { get; set; }

        public DateTime? JRBDWSJ { get; set; }

        [StringLength(50)]
        public string SFZHM { get; set; }

        [StringLength(50)]
        public string GZGW { get; set; }

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

        public DateTime? ZXSJ { get; set; }

        [StringLength(200)]
        public string BZ { get; set; }

        [StringLength(32)]
        public string BM { get; set; }

        [Column(TypeName = "float")]
        public decimal? BYXZJBGZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? BYXZGWGZ { get; set; }

        [StringLength(32)]
        public string FLAG { get; set; }

        [StringLength(64)]
        public string YEARLESS { get; set; }
    }
}
