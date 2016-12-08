namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_JSYDBP_BCGDDJK_DETAIL")]
    public partial class TBL_JSYDBP_BCGDDJK_DETAIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string BCGDDJKID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal OID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ID { get; set; }

        [StringLength(32)]
        public string XSQ { get; set; }

        [StringLength(256)]
        public string DKWZ { get; set; }

        [StringLength(256)]
        public string DJTB { get; set; }

        [StringLength(256)]
        public string DJTF { get; set; }

        [Column(TypeName = "float")]
        public decimal? YSMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? DKMJ { get; set; }

        [StringLength(8)]
        public string QLQW { get; set; }

        [StringLength(20)]
        public string BBH { get; set; }
    }
}
