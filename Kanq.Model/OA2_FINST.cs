namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.OA2_FINST")]
    public partial class OA2_FINST
    {
        [Key]
        [StringLength(20)]
        public string FI_INST { get; set; }

        public decimal? OWNER { get; set; }

        public decimal? FI_TALERT { get; set; }

        public DateTime? FI_ETIME { get; set; }

        public decimal? FI_STATE { get; set; }

        public decimal? FI_FLOW { get; set; }

        public decimal? FI_TDELAY { get; set; }

        public byte[] FI_DATA { get; set; }

        public DateTime? FI_STIME { get; set; }

        public decimal? FI_TTRAN { get; set; }

        public decimal? FI_TURGE { get; set; }

        [StringLength(500)]
        public string FI_USERS { get; set; }

        public DateTime? FI_TTIME { get; set; }

        public DateTime? FI_UTIME { get; set; }

        public DateTime? FI_ATIME { get; set; }

        [StringLength(512)]
        public string FI_FORMS { get; set; }

        public decimal? FI_FLOWV { get; set; }

        public decimal? FI_TYPE { get; set; }
    }
}
