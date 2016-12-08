namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_JSYDBP_BCGDDJK_ZB1")]
    public partial class TBL_JSYDBP_BCGDDJK_ZB1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string BCGDDJKID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string OID { get; set; }

        [StringLength(200)]
        public string BCGDDD { get; set; }

        [Column(TypeName = "float")]
        public decimal? JZGDMJ { get; set; }

        [StringLength(200)]
        public string YSDW { get; set; }

        public DateTime? YSSJ { get; set; }

        [StringLength(20)]
        public string SCBH { get; set; }

        [Column(TypeName = "float")]
        public decimal? SYMJ { get; set; }

        public decimal? GLZT { get; set; }

        [StringLength(20)]
        public string GLID { get; set; }

        [StringLength(128)]
        public string TF { get; set; }

        [StringLength(128)]
        public string TBH { get; set; }

        [Column(TypeName = "float")]
        public decimal? QZST { get; set; }

        [StringLength(256)]
        public string ZBQRDW { get; set; }

        public DateTime? QRSJ { get; set; }

        [StringLength(256)]
        public string ZXDWZ { get; set; }

        [StringLength(64)]
        public string YDL { get; set; }

        [Column(TypeName = "float")]
        public decimal? JSGM { get; set; }

        [StringLength(256)]
        public string YSWH { get; set; }

        public decimal? COUNT { get; set; }

        [StringLength(256)]
        public string XMWZ { get; set; }
    }
}
