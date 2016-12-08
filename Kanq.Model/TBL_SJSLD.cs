namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_SJSLD")]
    public partial class TBL_SJSLD
    {
        [Key]
        [StringLength(20)]
        public string SJSLDID { get; set; }

        [StringLength(50)]
        public string ND { get; set; }

        [StringLength(50)]
        public string BH { get; set; }

        [StringLength(200)]
        public string YWLX { get; set; }

        [StringLength(500)]
        public string SQDW { get; set; }

        [StringLength(50)]
        public string SQRSFZH { get; set; }

        [StringLength(300)]
        public string SSXZ { get; set; }

        [StringLength(500)]
        public string TDZL { get; set; }

        [StringLength(2000)]
        public string SQNRSM { get; set; }

        [StringLength(30)]
        public string ZXFWDH { get; set; }

        [StringLength(50)]
        public string JJR { get; set; }

        [StringLength(50)]
        public string SJR { get; set; }

        public DateTime? SJRQ { get; set; }

        [StringLength(100)]
        public string ZDH { get; set; }

        [StringLength(50)]
        public string ZSH { get; set; }

        [StringLength(30)]
        public string FH1 { get; set; }

        [StringLength(30)]
        public string FH2 { get; set; }

        [StringLength(30)]
        public string FH3 { get; set; }

        [StringLength(100)]
        public string XZQ { get; set; }

        [StringLength(50)]
        public string CARY { get; set; }

        [StringLength(200)]
        public string CBKS { get; set; }

        [StringLength(500)]
        public string SQDWDZ { get; set; }

        [StringLength(30)]
        public string SQDWDH { get; set; }

        [StringLength(30)]
        public string YZBM { get; set; }

        [StringLength(50)]
        public string TBRXM { get; set; }

        [StringLength(30)]
        public string TBRLXDH { get; set; }

        [StringLength(50)]
        public string SFZH { get; set; }

        [StringLength(200)]
        public string LCMC { get; set; }

        [StringLength(500)]
        public string XMMC { get; set; }

        [StringLength(500)]
        public string XMWZ { get; set; }

        [StringLength(30)]
        public string XMNF { get; set; }

        [StringLength(50)]
        public string QJRQZ { get; set; }

        [StringLength(100)]
        public string BLJGCXWZ { get; set; }

        [StringLength(500)]
        public string SM { get; set; }

        [StringLength(100)]
        public string ZJLX { get; set; }

        [StringLength(100)]
        public string ZJBH { get; set; }

        [StringLength(100)]
        public string XZFLDPS { get; set; }

        [StringLength(100)]
        public string JZPS { get; set; }

        [StringLength(100)]
        public string FGJZPS { get; set; }

        [StringLength(100)]
        public string JBRYJ { get; set; }

        [StringLength(100)]
        public string JBR { get; set; }

        public DateTime? JBSJ { get; set; }

        [StringLength(100)]
        public string FZR { get; set; }

        public DateTime? FSJ { get; set; }

        [StringLength(100)]
        public string TDLYFS { get; set; }

        [StringLength(100)]
        public string BZYTDWZ { get; set; }

        [StringLength(100)]
        public string BZYTDQSDW { get; set; }

        public decimal? SQYDMJ { get; set; }

        public decimal? GYTD { get; set; }

        public decimal? SSNYDMJ { get; set; }

        public decimal? GD { get; set; }

        public decimal? SQZSJTTDMJ { get; set; }

        public decimal? SQSYJTTDMJ { get; set; }

        [StringLength(100)]
        public string BZ { get; set; }

        [StringLength(100)]
        public string SQYDDW { get; set; }

        [StringLength(100)]
        public string FGJZQZ { get; set; }

        public DateTime? FGJZQZSJ { get; set; }

        [StringLength(100)]
        public string JZQZ { get; set; }

        public DateTime? JZQZSJ { get; set; }

        [StringLength(100)]
        public string XZFLDQZ { get; set; }

        public DateTime? XZFLDQZSJ { get; set; }

        [StringLength(2000)]
        public string FGDSQNRSM { get; set; }

        [StringLength(2000)]
        public string YJDSQNRSM { get; set; }

        [StringLength(200)]
        public string YWLXZL { get; set; }

        [StringLength(3)]
        public string BS { get; set; }

        [StringLength(3)]
        public string ZIDIANBS { get; set; }

        [StringLength(16)]
        public string SJRDH { get; set; }

        [StringLength(32)]
        public string JSYDXZ { get; set; }

        [StringLength(10)]
        public string XMLX { get; set; }
    }
}
