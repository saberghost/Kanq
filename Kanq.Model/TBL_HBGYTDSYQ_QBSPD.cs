namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.TBL_HBGYTDSYQ_QBSPD")]
    public partial class TBL_HBGYTDSYQ_QBSPD
    {
        [Key]
        [StringLength(20)]
        public string QBSPDID { get; set; }

        [StringLength(500)]
        public string XZFYJ { get; set; }

        [StringLength(50)]
        public string XLDQZ { get; set; }

        public DateTime? XLDQZRQ { get; set; }

        [StringLength(500)]
        public string JLDYJ { get; set; }

        [StringLength(300)]
        public string JLDQZ { get; set; }

        public DateTime? JLDQZRQ { get; set; }

        [StringLength(500)]
        public string ZGLDYJ { get; set; }

        [StringLength(50)]
        public string ZGLDQZ { get; set; }

        public DateTime? ZGLDQZRQ { get; set; }

        [StringLength(500)]
        public string FZRYJ { get; set; }

        [StringLength(50)]
        public string FZRQZ { get; set; }

        public DateTime? FZRQZRQ { get; set; }

        [StringLength(500)]
        public string JBRYJ { get; set; }

        [StringLength(50)]
        public string JBRQZ { get; set; }

        public DateTime? JBRQZRQ { get; set; }

        [StringLength(200)]
        public string TDQSDW { get; set; }

        [StringLength(200)]
        public string TDLY { get; set; }

        [StringLength(200)]
        public string TDWZ { get; set; }

        [StringLength(200)]
        public string TDGYFS { get; set; }

        [StringLength(200)]
        public string NHBDW { get; set; }

        [StringLength(200)]
        public string NJSXM { get; set; }

        [Column(TypeName = "float")]
        public decimal? TDZMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? KCMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? HBMJ { get; set; }

        [StringLength(200)]
        public string GHYT { get; set; }

        [StringLength(200)]
        public string TDDJ { get; set; }

        [StringLength(64)]
        public string RJL { get; set; }

        [StringLength(64)]
        public string JZMD { get; set; }

        [StringLength(64)]
        public string LDL { get; set; }

        [Column(TypeName = "float")]
        public decimal? JZMJ { get; set; }

        [StringLength(50)]
        public string ZDBH { get; set; }

        [Column(TypeName = "float")]
        public decimal? PGTDDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PGTDZJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PGFWDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? PGFWZJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? QSTDDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? QSTDZJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? QSFWDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? QSFWZJ { get; set; }

        [StringLength(2000)]
        public string BZ { get; set; }

        [StringLength(200)]
        public string TDSYQLX { get; set; }

        [Column(TypeName = "float")]
        public decimal? TDCRJDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? TDCRJZJ { get; set; }

        [StringLength(500)]
        public string ZFDDSCYJ { get; set; }

        [StringLength(50)]
        public string ZFDDSCR { get; set; }

        public DateTime? ZFDDSCRQ { get; set; }

        [StringLength(500)]
        public string DCKSHYJ { get; set; }

        [StringLength(50)]
        public string DCKSHR { get; set; }

        public DateTime? DCKSHRQ { get; set; }

        [StringLength(500)]
        public string DCZGSPYJ { get; set; }

        [StringLength(50)]
        public string DCZGLD { get; set; }

        public DateTime? DCZGSPRQ { get; set; }

        [StringLength(500)]
        public string JYZXSCYJ { get; set; }

        [StringLength(50)]
        public string JYZXSCR { get; set; }

        public DateTime? JYZXSCRQ { get; set; }

        [StringLength(500)]
        public string DJKCSYJ { get; set; }

        [StringLength(50)]
        public string DJKCSR { get; set; }

        public DateTime? DJKCSRQ { get; set; }

        [StringLength(500)]
        public string DJKZSHYJ { get; set; }

        [StringLength(50)]
        public string DJKZQZ { get; set; }

        public DateTime? DJKZQZRQ { get; set; }

        [StringLength(500)]
        public string DJZGSPYJ { get; set; }

        [StringLength(50)]
        public string DJZGLDQZ { get; set; }

        public DateTime? DJZGLDQZRQ { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGCRMJYTDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGCRMJCRMJ { get; set; }

        [StringLength(300)]
        public string XGCRMJXGYJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGCRMJXGHTDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGCRMJCRMJ1 { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGCRMJBCDJK { get; set; }

        [StringLength(50)]
        public string XGTDYTYGHYT { get; set; }

        [StringLength(200)]
        public string XGTDYTXGYJ { get; set; }

        [StringLength(50)]
        public string XGTDYTXGHGHYT { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGTDYTBCDJK { get; set; }

        [StringLength(100)]
        public string XGCRNXYCRNX { get; set; }

        [StringLength(300)]
        public string XGCRNXXGYJ { get; set; }

        [StringLength(200)]
        public string XGCRNXXGHNX { get; set; }

        [StringLength(100)]
        public string XGRJLYRJL { get; set; }

        [StringLength(200)]
        public string XGRJLXGYJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGCRNXBCDJK { get; set; }

        [StringLength(100)]
        public string XGRJLXGHRJL { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGRJLBCDJK { get; set; }

        [Column(TypeName = "float")]
        public decimal? BJDJKDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? BJDJKZJ { get; set; }

        [StringLength(20)]
        public string CTDCRDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CTDCRZJ { get; set; }

        [StringLength(4000)]
        public string BJDJKJSS { get; set; }

        [StringLength(400)]
        public string CCRJJSS { get; set; }

        [StringLength(50)]
        public string CRNX { get; set; }

        [Column(TypeName = "float")]
        public decimal? CNMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CJTDDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CJTDZJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CJFWDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CJFWZJ { get; set; }

        [StringLength(200)]
        public string SRDW { get; set; }

        [Column(TypeName = "float")]
        public decimal? YBDJK { get; set; }

        [Column(TypeName = "float")]
        public decimal? YBDJK1 { get; set; }

        [Column(TypeName = "float")]
        public decimal? QJDJK { get; set; }

        [StringLength(100)]
        public string YTDZH { get; set; }

        [StringLength(100)]
        public string WGH { get; set; }

        [Column(TypeName = "float")]
        public decimal? CRJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CJJDJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? CJJZJ { get; set; }

        public DateTime? CJSJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? TZE { get; set; }

        [Column(TypeName = "float")]
        public decimal? GPQSJ { get; set; }

        [StringLength(100)]
        public string ZYSPWH { get; set; }

        [Column(TypeName = "float")]
        public decimal? DJKYDJN { get; set; }

        [Column(TypeName = "float")]
        public decimal? DJKYJJK { get; set; }

        [Column(TypeName = "float")]
        public decimal? DJKQJJK { get; set; }

        [Column(TypeName = "float")]
        public decimal? BZJ { get; set; }

        public DateTime? CRSJ { get; set; }

        [StringLength(100)]
        public string XGHYT { get; set; }

        public DateTime? ZZRQ { get; set; }

        [StringLength(50)]
        public string JLDXM { get; set; }

        [StringLength(300)]
        public string DCKQZ { get; set; }

        [StringLength(500)]
        public string DCKZYJ { get; set; }

        [StringLength(100)]
        public string DCKZXM { get; set; }

        [StringLength(300)]
        public string DCKZQZ { get; set; }

        public DateTime? DCKZSPSJ { get; set; }

        [StringLength(300)]
        public string DCZGLDQZ { get; set; }

        [StringLength(300)]
        public string XZFQZ { get; set; }

        [StringLength(300)]
        public string XGJZMDYJZMD { get; set; }

        [StringLength(300)]
        public string XGJZMDXGYJ { get; set; }

        [StringLength(300)]
        public string XGJZMDXGHJZMD { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGJZMDBJDJK { get; set; }

        [StringLength(300)]
        public string XGLDLYLDL { get; set; }

        [StringLength(300)]
        public string XGLDLXGYJ { get; set; }

        [StringLength(300)]
        public string XGLDLXGHLDL { get; set; }

        [Column(TypeName = "float")]
        public decimal? XGLDLBJDJK { get; set; }

        [StringLength(100)]
        public string ZRF { get; set; }

        [StringLength(32)]
        public string ZRFFDDBR { get; set; }

        [StringLength(100)]
        public string SRF { get; set; }

        [StringLength(200)]
        public string SRFFDDBR { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZRTDZMJ { get; set; }

        [StringLength(32)]
        public string ZRQTDYT { get; set; }

        [StringLength(32)]
        public string ZRHTDYT { get; set; }

        [StringLength(300)]
        public string TDZH { get; set; }

        [StringLength(50)]
        public string FWSUQR { get; set; }

        [StringLength(200)]
        public string FWCQZH { get; set; }

        [StringLength(32)]
        public string ZRSTDPGJG { get; set; }

        [Column(TypeName = "float")]
        public decimal? SFXYZRJE { get; set; }

        [StringLength(50)]
        public string NCRDX { get; set; }

        [StringLength(32)]
        public string CRXS { get; set; }

        [StringLength(200)]
        public string JSYDPFWH { get; set; }

        [StringLength(32)]
        public string YTDSYZH { get; set; }

        [StringLength(32)]
        public string ZDH { get; set; }

        [StringLength(32)]
        public string QLR { get; set; }

        [StringLength(100)]
        public string YJGH { get; set; }

        [StringLength(100)]
        public string EJGH { get; set; }

        [StringLength(100)]
        public string XGHYJGH { get; set; }

        [StringLength(100)]
        public string XGHEJGH { get; set; }

        [Column(TypeName = "float")]
        public decimal? SYJ { get; set; }

        public DateTime? JSSJ { get; set; }

        [StringLength(32)]
        public string DCKNAME { get; set; }

        [StringLength(32)]
        public string DCKZNAME { get; set; }

        [StringLength(32)]
        public string FGJZNAME { get; set; }

        [StringLength(32)]
        public string JZNAME { get; set; }

        [StringLength(30)]
        public string CKBH { get; set; }

        [StringLength(100)]
        public string QSLY { get; set; }

        [StringLength(100)]
        public string TEMP { get; set; }

        [StringLength(100)]
        public string SFXYZRJEDW { get; set; }

        [StringLength(100)]
        public string SYJDW { get; set; }

        [StringLength(100)]
        public string CRJDW { get; set; }

        [Column(TypeName = "float")]
        public decimal? NYDZYMJ { get; set; }

        [StringLength(100)]
        public string PCMC { get; set; }

        [StringLength(100)]
        public string PFWH { get; set; }

        [Column(TypeName = "float")]
        public decimal? GDMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? BPZMJ { get; set; }
    }
}
