namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_HBGYTDSYQ_QBSPD_ZB")]
    public partial class TBL_HBGYTDSYQ_QBSPD_ZB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string QBSPDID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal OID { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZMJ { get; set; }

        [StringLength(100)]
        public string PCMC { get; set; }

        [StringLength(100)]
        public string PFWH { get; set; }

        [Column(TypeName = "float")]
        public decimal? GDMJ { get; set; }

        [StringLength(20)]
        public string GY_BPID { get; set; }

        [StringLength(20)]
        public string BPSLH { get; set; }
    }
}
