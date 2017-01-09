namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_ZDCQ_ZFHBBT")]
    public partial class TBL_ZDCQ_ZFHBBT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal? ID { get; set; }

        [StringLength(256)]
        public string XMMC { get; set; }

        [StringLength(128)]
        public string PC { get; set; }

        public decimal? HS { get; set; }

        public decimal? NYRK { get; set; }

        public decimal? DSZN { get; set; }

        public decimal? FNYRK { get; set; }

        public decimal? XJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZXCZ1 { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZXCZ2 { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZXCZ3 { get; set; }

        [Column(TypeName = "float")]
        public decimal? CJTCZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? LJTCZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CQZXCZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? SGGJCZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? XZGYYCZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? KGCGWHCZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZDGCJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? SLJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HHZBQ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HJT { get; set; }

        [Column(TypeName = "float")]
        public decimal? GTJCZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HJJE { get; set; }

        public DateTime? QKSJ { get; set; }

        [StringLength(1024)]
        public string BZ { get; set; }

        public decimal? YEAR { get; set; }
    }
}
