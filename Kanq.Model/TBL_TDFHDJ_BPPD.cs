namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_TDFHDJ_BPPD")]
    public partial class TBL_TDFHDJ_BPPD
    {
        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(256)]
        public string XMMC { get; set; }

        [StringLength(256)]
        public string PZDW { get; set; }

        [StringLength(256)]
        public string XMLX { get; set; }

        [StringLength(256)]
        public string PZWH { get; set; }

        public DateTime? PZRQ { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? BPSYMJ { get; set; }

        [StringLength(256)]
        public string GWYPFWH { get; set; }

        public DateTime? GWYPFRQ { get; set; }

        [Column(TypeName = "float")]
        public decimal? GWYPFBSMJ { get; set; }

        [StringLength(64)]
        public string JSXMBH { get; set; }

        [StringLength(300)]
        public string TDZL { get; set; }

        [Column(TypeName = "float")]
        public decimal? PZXMXZJSYDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PZXMNYDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PZXMGDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PZXMJBNTMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PZXMJSYDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PZXMWLYDMJ { get; set; }

        [StringLength(50)]
        public string DZJGH { get; set; }
    }
}
