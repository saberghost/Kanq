namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_TDTJBG_HTJBXX")]
    public partial class TBL_TDTJBG_HTJBXX
    {
        [StringLength(200)]
        public string SRDW { get; set; }

        [StringLength(30)]
        public string TDQSDW { get; set; }

        [StringLength(2000)]
        public string TDWZ { get; set; }

        [StringLength(100)]
        public string TDYT { get; set; }

        [Column(TypeName = "float")]
        public decimal? TDZMJ { get; set; }

        [StringLength(100)]
        public string SYQLX { get; set; }

        public DateTime? CJSJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? GPQSZJ { get; set; }

        [StringLength(200)]
        public string CRJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CRJKDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? YJJK { get; set; }

        [Column(TypeName = "float")]
        public decimal? TZE { get; set; }

        [StringLength(200)]
        public string RJL { get; set; }

        [StringLength(100)]
        public string PZWH { get; set; }

        [StringLength(200)]
        public string YDJDSJ { get; set; }

        [StringLength(200)]
        public string YDJGSJ { get; set; }

        [StringLength(100)]
        public string ZSSPWH { get; set; }

        [StringLength(100)]
        public string ZFPZHYJYHWH { get; set; }

        [StringLength(100)]
        public string LXR { get; set; }

        [StringLength(1800)]
        public string BZ { get; set; }

        public DateTime? CRSJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CRMJ { get; set; }

        [StringLength(1000)]
        public string CRFS { get; set; }

        [StringLength(100)]
        public string WGH { get; set; }

        [Column(TypeName = "float")]
        public decimal? BZJ { get; set; }

        [StringLength(100)]
        public string YDJNQX { get; set; }

        [Column(TypeName = "float")]
        public decimal? CRJKZJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? QJJK { get; set; }

        [StringLength(100)]
        public string CRNX { get; set; }

        [StringLength(200)]
        public string JZMD { get; set; }

        [StringLength(200)]
        public string LDL { get; set; }

        [StringLength(100)]
        public string TDJB { get; set; }

        [StringLength(200)]
        public string YDKGSJ { get; set; }

        [StringLength(200)]
        public string HTQDSJ { get; set; }

        [StringLength(100)]
        public string DJGH { get; set; }

        [StringLength(100)]
        public string PGBAH { get; set; }

        [StringLength(100)]
        public string LXDH { get; set; }

        [Key]
        [StringLength(20)]
        public string HTJBXXID { get; set; }

        [StringLength(100)]
        public string HTBH { get; set; }

        [StringLength(100)]
        public string YWBZ { get; set; }

        [StringLength(500)]
        public string XMMC { get; set; }

        [StringLength(100)]
        public string ZDBH { get; set; }
    }
}
