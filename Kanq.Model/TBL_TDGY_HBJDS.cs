namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_TDGY_HBJDS")]
    public partial class TBL_TDGY_HBJDS
    {
        [Key]
        [StringLength(20)]
        public string HBJDSID { get; set; }

        [StringLength(50)]
        public string DZJGH { get; set; }

        [StringLength(50)]
        public string HBJDSWH { get; set; }

        [StringLength(300)]
        public string JSXMMC { get; set; }

        [StringLength(200)]
        public string SYQR { get; set; }

        [StringLength(200)]
        public string QFJG { get; set; }

        public DateTime? QFSJ { get; set; }

        [StringLength(200)]
        public string PZJG { get; set; }

        [StringLength(50)]
        public string PZWH { get; set; }

        [StringLength(200)]
        public string ZDYT { get; set; }

        [StringLength(50)]
        public string ZDBH { get; set; }

        [StringLength(300)]
        public string ZDZL { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZDZMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HBZDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HBJK { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZJZMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? JZXG { get; set; }

        [StringLength(100)]
        public string ZDPMJX { get; set; }

        [StringLength(100)]
        public string SXJXGC { get; set; }

        [StringLength(100)]
        public string SXJXS { get; set; }

        [StringLength(100)]
        public string SXJXX { get; set; }

        [StringLength(300)]
        public string XYJSXM { get; set; }

        [StringLength(50)]
        public string ZTJZWXZ { get; set; }

        [StringLength(50)]
        public string FZJZWXZ { get; set; }

        public DateTime? KGSJ { get; set; }

        public DateTime? JGSJ { get; set; }

        [StringLength(200)]
        public string QTYQ { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZFZMJ { get; set; }

        public decimal? ZFZTS { get; set; }

        public decimal? LZFTS { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZFMJ { get; set; }

        public decimal? ZFTS { get; set; }

        [StringLength(200)]
        public string YJZF { get; set; }

        [StringLength(100)]
        public string JZMD { get; set; }

        [StringLength(100)]
        public string JZRJL { get; set; }

        [StringLength(100)]
        public string LDL { get; set; }

        [StringLength(50)]
        public string HBJDSBH { get; set; }

        public DateTime? HBJDSQDSJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HBCBDJ { get; set; }

        public DateTime? HBJKJNSJ { get; set; }

        public DateTime? SJJNSJ { get; set; }

        [StringLength(300)]
        public string JFZM { get; set; }

        [StringLength(10)]
        public string QCBFGYF { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZPGCJJK { get; set; }

        [StringLength(100)]
        public string TDJB { get; set; }
    }
}
