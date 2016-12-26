namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_TDFHDJ_BPPD_ZB")]
    public partial class TBL_TDFHDJ_BPPD_ZB
    {
        [StringLength(20)]
        public string ND { get; set; }

        [StringLength(200)]
        public string XZQ { get; set; }

        [StringLength(1000)]
        public string JSXMMC { get; set; }

        [StringLength(1000)]
        public string SQYDDW { get; set; }

        [StringLength(300)]
        public string YDLB { get; set; }

        [StringLength(500)]
        public string PFWH { get; set; }

        public DateTime? PFSJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PZXMZMJ { get; set; }

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

        [StringLength(1000)]
        public string XMWZ { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string BPID_ZB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BPID { get; set; }
    }
}
