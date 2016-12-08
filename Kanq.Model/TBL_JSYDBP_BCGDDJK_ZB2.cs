namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_JSYDBP_BCGDDJK_ZB2")]
    public partial class TBL_JSYDBP_BCGDDJK_ZB2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string BCGDDJKID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal OID { get; set; }

        public DateTime? SJ { get; set; }

        [StringLength(400)]
        public string APJSXMJZYGDDW { get; set; }

        [StringLength(200)]
        public string ZYGDDW { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZYGDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? BCGDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? SYGDMJ { get; set; }

        [StringLength(20)]
        public string GLID { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZYD { get; set; }

        [StringLength(2048)]
        public string BZ { get; set; }

        [StringLength(256)]
        public string YDWZ { get; set; }

        [Column(TypeName = "float")]
        public decimal? NYD { get; set; }

        [Column(TypeName = "float")]
        public decimal? ST { get; set; }

        [Column(TypeName = "float")]
        public decimal? HD { get; set; }

        public decimal? COUNT { get; set; }
    }
}
