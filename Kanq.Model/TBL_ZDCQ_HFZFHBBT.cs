namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_ZDCQ_HFZFHBBT")]
    public partial class TBL_ZDCQ_HFZFHBBT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal? ID { get; set; }

        [StringLength(256)]
        public string XMMC { get; set; }

        [StringLength(128)]
        public string PC { get; set; }

        public decimal? HS { get; set; }

        public decimal? NYRK { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZXCZ1 { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZXCZ2 { get; set; }

        [Column(TypeName = "float")]
        public decimal? HJJE { get; set; }

        public DateTime? QKSJ { get; set; }

        [StringLength(1024)]
        public string BZ { get; set; }

        public decimal? YEAR { get; set; }
    }
}
