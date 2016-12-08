namespace Kanq.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSYZT.D_REC")]
    public partial class D_REC
    {
        [Key]
        [StringLength(20)]
        public string SLID { get; set; }

        [StringLength(100)]
        public string WF_TPYE { get; set; }

        public decimal? REGTYPE { get; set; }

        public decimal? REGSTAT { get; set; }

        [StringLength(600)]
        public string GWBT { get; set; }

        public DateTime? JSSJ { get; set; }

        [StringLength(50)]
        public string CBR { get; set; }

        [StringLength(50)]
        public string CBKS { get; set; }

        [StringLength(2000)]
        public string SMJREC { get; set; }

        [StringLength(100)]
        public string LWBH { get; set; }

        [StringLength(20)]
        public string SWBWDID { get; set; }

        [StringLength(48)]
        public string ZDYKJ { get; set; }

        [StringLength(50)]
        public string GKFW { get; set; }

        [StringLength(10)]
        public string EMERGENCY { get; set; }

        public decimal? AGENT { get; set; }

        public decimal? OVERSEE { get; set; }

        public decimal? PFTYPE { get; set; }

        public decimal? WORDSTATE { get; set; }

        [Column(TypeName = "long")]
        public string WORDTEXT { get; set; }

        [StringLength(100)]
        public string CEBID { get; set; }

        public decimal? GUAQI { get; set; }

        public decimal? YANQI { get; set; }

        [StringLength(60)]
        public string HISTORYWORD { get; set; }

        public decimal? CONVERTCEB { get; set; }

        public decimal? FLOWSTATE { get; set; }

        [StringLength(2000)]
        public string WORDDIRTYRECORD { get; set; }

        [StringLength(32)]
        public string CK_GUID { get; set; }

        [StringLength(300)]
        public string REDTEMPLATENAME { get; set; }

        [StringLength(32)]
        public string TK_SQXH { get; set; }

        public decimal? ISEXISTSLINKMAN { get; set; }

        [StringLength(200)]
        public string BUSNUM { get; set; }

        [StringLength(12)]
        public string REGID { get; set; }

        [StringLength(12)]
        public string UNIID { get; set; }

        [StringLength(200)]
        public string PEOPTEL { get; set; }

        public DateTime? BUSDATA { get; set; }

        [StringLength(200)]
        public string PEOPINC { get; set; }

        [StringLength(200)]
        public string PEOPLES { get; set; }

        [StringLength(200)]
        public string PEOPADD { get; set; }

        [StringLength(12)]
        public string ZDID { get; set; }

        [StringLength(200)]
        public string BUSREC { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string BUSINES { get; set; }

        [StringLength(24)]
        public string RESID { get; set; }

        public decimal? SFZZYDFGDJ { get; set; }

        [StringLength(500)]
        public string SJXZSM { get; set; }

        public decimal? EXPORTSTATE { get; set; }

        [StringLength(50)]
        public string LDCERLD { get; set; }

        [StringLength(128)]
        public string PHID { get; set; }

        [StringLength(10)]
        public string CWSQID { get; set; }

        [StringLength(20)]
        public string BGSRWID { get; set; }

        [StringLength(20)]
        public string TDDJSFDID { get; set; }

        [StringLength(10)]
        public string GTID { get; set; }

        [StringLength(100)]
        public string WF_TYPE { get; set; }

        [StringLength(50)]
        public string LDCERID { get; set; }

        [StringLength(20)]
        public string OLDSLID { get; set; }

        [StringLength(20)]
        public string ZFZID { get; set; }

        [StringLength(38)]
        public string KCDJCG2 { get; set; }

        [StringLength(20)]
        public string BYJZSID { get; set; }

        [StringLength(38)]
        public string XMCBSMSID { get; set; }

        [StringLength(38)]
        public string NYDZYFAID { get; set; }

        [StringLength(38)]
        public string BCGDFAID { get; set; }

        [StringLength(38)]
        public string ZYTDFAID { get; set; }

        [StringLength(38)]
        public string SSNYDBASPBID { get; set; }

        [StringLength(38)]
        public string SSNYDBAZID { get; set; }

        [StringLength(38)]
        public string JSYDPZSID { get; set; }

        [StringLength(38)]
        public string LSYDSPBID { get; set; }

        [StringLength(38)]
        public string LYXXBGBID { get; set; }

        [StringLength(100)]
        public string RESNO { get; set; }

        [StringLength(38)]
        public string JSYDYSID { get; set; }

        [StringLength(100)]
        public string LANDNO { get; set; }

        [StringLength(20)]
        public string PZSID { get; set; }

        [StringLength(20)]
        public string SPCBBID { get; set; }

        [StringLength(30)]
        public string GDFAID { get; set; }

        [StringLength(20)]
        public string GDSLID { get; set; }

        [StringLength(20)]
        public string DZSLID { get; set; }

        [StringLength(20)]
        public string GYSLID { get; set; }

        [Column(TypeName = "float")]
        public decimal? YDZMJ { get; set; }

        [StringLength(20)]
        public string SJDID { get; set; }

        [StringLength(38)]
        public string JSYDSQBID { get; set; }

        [StringLength(20)]
        public string SCBID { get; set; }

        [StringLength(38)]
        public string TZFAID { get; set; }

        [StringLength(38)]
        public string NZDQSHZID { get; set; }

        [StringLength(38)]
        public string ZBID { get; set; }

        [StringLength(32)]
        public string KCZYNJID { get; set; }

        [StringLength(32)]
        public string KCZYNBID { get; set; }

        [StringLength(32)]
        public string KCNJID { get; set; }

        [StringLength(32)]
        public string CKBCID { get; set; }

        [StringLength(32)]
        public string QJID { get; set; }

        [StringLength(32)]
        public string HBID { get; set; }

        [StringLength(32)]
        public string HYID { get; set; }

        [StringLength(32)]
        public string GHID { get; set; }

        [StringLength(32)]
        public string CHID { get; set; }

        [StringLength(32)]
        public string TDID { get; set; }

        [StringLength(32)]
        public string WXID { get; set; }

        [StringLength(32)]
        public string YYID { get; set; }

        [StringLength(32)]
        public string HYID1 { get; set; }

        [StringLength(32)]
        public string RZID { get; set; }

        [StringLength(32)]
        public string CBID { get; set; }

        [StringLength(38)]
        public string PL_ID { get; set; }

        [StringLength(20)]
        public string HBGDFAID { get; set; }

        [StringLength(38)]
        public string PGBID { get; set; }

        [StringLength(38)]
        public string LXSQID { get; set; }

        [StringLength(38)]
        public string LXZBBID { get; set; }

        [StringLength(30)]
        public string XCKCID { get; set; }

        [StringLength(30)]
        public string XMYSCBBID { get; set; }

        [StringLength(30)]
        public string AG_INDEX { get; set; }

        [StringLength(30)]
        public string YLBID { get; set; }

        [StringLength(22)]
        public string LZDID { get; set; }

        [StringLength(22)]
        public string TZID { get; set; }

        [StringLength(30)]
        public string KCDJZLID { get; set; }

        [StringLength(30)]
        public string GHLSID { get; set; }

        [StringLength(30)]
        public string YLZBID { get; set; }

        [StringLength(30)]
        public string YASQID { get; set; }

        [StringLength(22)]
        public string DJTZID { get; set; }

        [StringLength(22)]
        public string TDTBDJKID { get; set; }

        [StringLength(22)]
        public string KCTBDJKID { get; set; }

        [StringLength(22)]
        public string CCDJKID { get; set; }

        [StringLength(22)]
        public string LACPBID { get; set; }

        [StringLength(22)]
        public string SPHQBID { get; set; }

        [StringLength(22)]
        public string JACPBID { get; set; }

        [StringLength(38)]
        public string LXCBBID { get; set; }

        [StringLength(38)]
        public string SBFKDID { get; set; }

        [StringLength(22)]
        public string XCRZID { get; set; }

        [StringLength(22)]
        public string CLID { get; set; }

        [StringLength(38)]
        public string JBXXBID { get; set; }

        [StringLength(38)]
        public string TXGBID { get; set; }

        [StringLength(38)]
        public string ZGZCID { get; set; }

        [StringLength(38)]
        public string HQBID { get; set; }

        [StringLength(38)]
        public string HZBID { get; set; }

        [StringLength(38)]
        public string YSHSBID { get; set; }

        [StringLength(22)]
        public string YJSQID { get; set; }

        [StringLength(10)]
        public string GSID { get; set; }

        [StringLength(38)]
        public string TBDJKID { get; set; }

        [StringLength(20)]
        public string SHTDID { get; set; }

        [StringLength(38)]
        public string DKXXID { get; set; }

        [StringLength(38)]
        public string JGYSCBID { get; set; }

        [StringLength(38)]
        public string JSYDYCFKID { get; set; }

        [StringLength(38)]
        public string NCGRYCFKID { get; set; }

        [StringLength(38)]
        public string HJQXXBID { get; set; }

        [StringLength(38)]
        public string BNSSDKXXBID { get; set; }

        [StringLength(38)]
        public string TZQHXXQKBID { get; set; }

        [StringLength(38)]
        public string TXSCID { get; set; }

        [StringLength(38)]
        public string HZBOID { get; set; }

        [StringLength(22)]
        public string ZFWSID { get; set; }

        [StringLength(22)]
        public string GRJFXXCJID { get; set; }

        [StringLength(20)]
        public string FWBID { get; set; }

        [StringLength(100)]
        public string GRJFSQR { get; set; }

        [StringLength(50)]
        public string SFZHM { get; set; }

        [StringLength(50)]
        public string HJDZ { get; set; }

        [StringLength(38)]
        public string YSHID { get; set; }

        [StringLength(100)]
        public string SQRXZDZ { get; set; }

        [StringLength(200)]
        public string QFKJ { get; set; }

        [StringLength(38)]
        public string CBPCID { get; set; }

        [StringLength(38)]
        public string JBNTHXID { get; set; }

        [StringLength(38)]
        public string GHJDZBID { get; set; }

        [StringLength(38)]
        public string CBSGID { get; set; }

        public decimal? CFZT { get; set; }

        [StringLength(20)]
        public string XYCRFAID { get; set; }

        [StringLength(38)]
        public string PCGDBID { get; set; }

        [StringLength(200)]
        public string ZT { get; set; }

        [StringLength(200)]
        public string XMMC { get; set; }

        [StringLength(200)]
        public string XMDD { get; set; }

        public DateTime? SLRQ { get; set; }

        [StringLength(200)]
        public string SLR { get; set; }

        [StringLength(200)]
        public string JB { get; set; }

        [StringLength(200)]
        public string NF { get; set; }

        [StringLength(20)]
        public string ZPGGDFAID { get; set; }

        [StringLength(20)]
        public string HYID2 { get; set; }

        [StringLength(20)]
        public string BGLYSLID { get; set; }

        public decimal? DYZT { get; set; }

        [StringLength(20)]
        public string GHFAID { get; set; }

        [StringLength(38)]
        public string NZBID { get; set; }

        [StringLength(22)]
        public string AJSLID { get; set; }

        [StringLength(22)]
        public string CCGALAID { get; set; }

        [StringLength(22)]
        public string TDGALAID { get; set; }

        [StringLength(22)]
        public string XWBLID { get; set; }

        [StringLength(22)]
        public string ZJBCID { get; set; }

        [StringLength(22)]
        public string AJJDID { get; set; }

        [StringLength(22)]
        public string DCZJID { get; set; }

        [StringLength(22)]
        public string CLJDCBBID { get; set; }

        [StringLength(22)]
        public string XZCFGZSID { get; set; }

        [StringLength(22)]
        public string FLWSCPBID { get; set; }

        [StringLength(22)]
        public string DCXZCFID { get; set; }

        [StringLength(22)]
        public string XZCFJYID { get; set; }

        [StringLength(22)]
        public string FFCWYJSID { get; set; }

        [StringLength(22)]
        public string TDCFJDID { get; set; }

        [StringLength(22)]
        public string TDDZJCFJDID { get; set; }

        [StringLength(22)]
        public string TDDZJCFJYID { get; set; }

        [StringLength(22)]
        public string KCCFJDID { get; set; }

        [StringLength(22)]
        public string KCDZJCFJDID { get; set; }

        [StringLength(22)]
        public string KCDZJCFJYID { get; set; }

        [StringLength(22)]
        public string QZZXID { get; set; }

        [StringLength(22)]
        public string YBLXID { get; set; }

        [StringLength(22)]
        public string TDJAID { get; set; }

        [StringLength(22)]
        public string TDDZJCFJYZXID { get; set; }

        [StringLength(22)]
        public string TDXFZXID { get; set; }

        [StringLength(22)]
        public string KCJAID { get; set; }

        [StringLength(22)]
        public string KCDZJCFJYZXID { get; set; }

        [StringLength(22)]
        public string KCXFZXID { get; set; }

        [StringLength(22)]
        public string XCKCEID { get; set; }

        [StringLength(22)]
        public string XZCFID { get; set; }

        [StringLength(32)]
        public string DZDBGID { get; set; }

        [StringLength(22)]
        public string FFSBID { get; set; }

        [StringLength(20)]
        public string ZC_ID { get; set; }

        [StringLength(20)]
        public string RM_ID { get; set; }

        [StringLength(22)]
        public string DSRXXID { get; set; }

        [StringLength(22)]
        public string TZGZSID { get; set; }

        [StringLength(22)]
        public string SDHZID { get; set; }

        [StringLength(22)]
        public string CFTZTZSID { get; set; }

        [StringLength(22)]
        public string XZCFTZBLID { get; set; }

        [StringLength(22)]
        public string CHBID { get; set; }

        [StringLength(22)]
        public string SXFZAJYJSID { get; set; }

        [StringLength(22)]
        public string YSQKID { get; set; }

        [StringLength(50)]
        public string ZB_ID { get; set; }

        [StringLength(20)]
        public string ZFXZ { get; set; }

        [StringLength(20)]
        public string GZZFXZ { get; set; }

        [StringLength(38)]
        public string HZDWID { get; set; }

        [StringLength(20)]
        public string WFHQZF { get; set; }

        [StringLength(38)]
        public string GHSJYSBZID { get; set; }

        [StringLength(200)]
        public string XMBH { get; set; }

        [StringLength(200)]
        public string PZJG { get; set; }

        [StringLength(200)]
        public string PFWH { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZMJ { get; set; }

        [Column(TypeName = "float")]
        public decimal? ZYGDMJ { get; set; }

        [StringLength(10)]
        public string NORM_DOC { get; set; }

        [StringLength(30)]
        public string DHZBID { get; set; }

        [StringLength(30)]
        public string ZXZBID { get; set; }

        [StringLength(22)]
        public string KCPZID { get; set; }

        [StringLength(38)]
        public string TXGBID1 { get; set; }

        [StringLength(22)]
        public string DJID { get; set; }

        [StringLength(22)]
        public string SLGZID { get; set; }

        [StringLength(38)]
        public string GDTZID { get; set; }

        [StringLength(22)]
        public string DFID { get; set; }

        [StringLength(22)]
        public string BSLGZID { get; set; }

        [StringLength(22)]
        public string BZSLGZID { get; set; }

        [StringLength(100)]
        public string YSWH { get; set; }

        [Column(TypeName = "float")]
        public decimal? JZGDMJ { get; set; }

        [StringLength(30)]
        public string CHMJBID { get; set; }

        [StringLength(100)]
        public string BALX1 { get; set; }

        [StringLength(50)]
        public string DJPGBID { get; set; }

        [StringLength(22)]
        public string BGID { get; set; }

        [StringLength(200)]
        public string DSRXX { get; set; }

        [StringLength(22)]
        public string YLTDFAAID { get; set; }

        [StringLength(22)]
        public string YLTDFABID { get; set; }

        [StringLength(22)]
        public string YLTDFACID { get; set; }

        [StringLength(22)]
        public string JDZBID { get; set; }

        [StringLength(100)]
        public string WFAJCXXZ { get; set; }

        [StringLength(100)]
        public string WFHQXZ { get; set; }

        [StringLength(22)]
        public string WFXSDJBID { get; set; }

        [StringLength(2)]
        public string DJLXBH { get; set; }

        [StringLength(100)]
        public string BGLX { get; set; }

        [StringLength(100)]
        public string DYDJLX { get; set; }

        public decimal? GLZT { get; set; }

        [StringLength(22)]
        public string CRHTID { get; set; }

        [StringLength(20)]
        public string HTID { get; set; }

        [StringLength(20)]
        public string GGID2 { get; set; }

        [StringLength(22)]
        public string XZTDRDDID { get; set; }

        [StringLength(22)]
        public string XZTDGZSID { get; set; }

        [StringLength(22)]
        public string XZTDRDSID { get; set; }

        public DateTime? DYZXRQ { get; set; }

        [StringLength(20)]
        public string SJR { get; set; }

        [StringLength(100)]
        public string KYDABH { get; set; }

        [StringLength(100)]
        public string DZJGH { get; set; }

        [StringLength(22)]
        public string LSYDLZDID { get; set; }

        [StringLength(100)]
        public string JBNTSHJG { get; set; }

        [StringLength(100)]
        public string JZJSQSHJG { get; set; }

        [StringLength(22)]
        public string SSNYDLZDID { get; set; }

        [StringLength(22)]
        public string WPTBXXID { get; set; }

        [StringLength(22)]
        public string WPTBHCMXID { get; set; }

        [StringLength(20)]
        public string TDWPZFXZ { get; set; }

        [StringLength(50)]
        public string GDQKID { get; set; }

        [StringLength(22)]
        public string PDFWID { get; set; }

        [StringLength(100)]
        public string DYSXH { get; set; }

        [StringLength(200)]
        public string YDJH { get; set; }

        public decimal? SLZT { get; set; }

        public decimal? TXGXZT { get; set; }

        [StringLength(22)]
        public string SSNYDBALSID { get; set; }

        [StringLength(22)]
        public string LSYDLSID { get; set; }

        [StringLength(22)]
        public string JSYDPZSLSID { get; set; }

        [StringLength(38)]
        public string BZJID { get; set; }

        [StringLength(38)]
        public string CRJJNID { get; set; }

        [StringLength(38)]
        public string QSZWID { get; set; }

        [StringLength(200)]
        public string QLRMC1 { get; set; }

        [StringLength(200)]
        public string QLRLXDH1 { get; set; }

        [StringLength(200)]
        public string QLRTXDZ1 { get; set; }

        [StringLength(200)]
        public string QLRLXR1 { get; set; }

        [StringLength(200)]
        public string QLRLXR { get; set; }

        [StringLength(200)]
        public string LZR { get; set; }

        public DateTime? LZRQ { get; set; }

        [StringLength(200)]
        public string DJFY { get; set; }

        [StringLength(200)]
        public string DJLXXQ { get; set; }

        [StringLength(22)]
        public string FQGKDID { get; set; }

        [StringLength(22)]
        public string JCQID { get; set; }

        [StringLength(200)]
        public string ZJGB { get; set; }

        [StringLength(50)]
        public string ZJBCQDID { get; set; }

        [StringLength(50)]
        public string ZZDCJDID { get; set; }

        [StringLength(50)]
        public string ZZDCJDID2 { get; set; }

        [StringLength(50)]
        public string CXLAJDID { get; set; }

        [StringLength(200)]
        public string JSDCID { get; set; }

        [StringLength(100)]
        public string CFJDCGID { get; set; }

        [StringLength(22)]
        public string CWQWID { get; set; }

        [StringLength(50)]
        public string HJID { get; set; }

        [StringLength(100)]
        public string CWQWYGJBNT { get; set; }

        [StringLength(100)]
        public string ZJID { get; set; }

        [StringLength(50)]
        public string HJJLID { get; set; }

        [StringLength(50)]
        public string WFAJSLJLID { get; set; }

        [StringLength(50)]
        public string ZBLX { get; set; }

        [StringLength(20)]
        public string CKXXID { get; set; }

        [StringLength(20)]
        public string YJSXDID { get; set; }

        [StringLength(20)]
        public string CKHTID { get; set; }

        [StringLength(20)]
        public string SCHTID { get; set; }

        [StringLength(20)]
        public string ZBCGBID { get; set; }

        [StringLength(20)]
        public string SPDID { get; set; }

        [StringLength(20)]
        public string CBJHGLID { get; set; }

        [StringLength(20)]
        public string TDZCQKHZBID { get; set; }

        [StringLength(20)]
        public string CZBFID { get; set; }

        [StringLength(20)]
        public string SCZJBFBID { get; set; }

        [StringLength(20)]
        public string TDJJSID { get; set; }

        [StringLength(20)]
        public string PGSHBSLID { get; set; }

        [StringLength(20)]
        public string SCFABID { get; set; }

        [StringLength(20)]
        public string QBSPDID { get; set; }

        [StringLength(20)]
        public string JSBID { get; set; }

        [StringLength(20)]
        public string SFJSBID { get; set; }

        [StringLength(20)]
        public string CRFAID { get; set; }

        [StringLength(20)]
        public string SJHZDID { get; set; }

        [StringLength(20)]
        public string SJSLDID { get; set; }

        [StringLength(20)]
        public string YSCBBID { get; set; }

        [StringLength(20)]
        public string YSSHBID { get; set; }

        [StringLength(20)]
        public string YWSQRXXID { get; set; }

        [StringLength(800)]
        public string SQSX { get; set; }

        [StringLength(20)]
        public string GDMLID { get; set; }

        [StringLength(20)]
        public string CBSMSID { get; set; }

        [StringLength(20)]
        public string NYDZYID { get; set; }

        [StringLength(20)]
        public string ZYTDID { get; set; }

        [StringLength(20)]
        public string BCGDID { get; set; }

        [StringLength(20)]
        public string GDFANID { get; set; }

        [StringLength(20)]
        public string BCGDDJKID { get; set; }

        [StringLength(20)]
        public string BPSPBID { get; set; }

        [StringLength(20)]
        public string BPDID { get; set; }

        [StringLength(20)]
        public string GDZYSSBSPBID { get; set; }

        [StringLength(20)]
        public string JFYDSQBID { get; set; }

        [StringLength(20)]
        public string JSYDXKZID { get; set; }

        [StringLength(20)]
        public string FWDJID { get; set; }

        [StringLength(20)]
        public string SWDJID { get; set; }

        [StringLength(50)]
        public string WSLID { get; set; }

        [StringLength(20)]
        public string SSNY_ID { get; set; }

        [StringLength(20)]
        public string LSYDCBBID { get; set; }

        [StringLength(50)]
        public string BH { get; set; }

        [StringLength(20)]
        public string GYTDCRCBBID { get; set; }

        [StringLength(100)]
        public string XZQ { get; set; }

        [StringLength(20)]
        public string ZFCGSBBID { get; set; }

        [StringLength(20)]
        public string XWZCGSPDID { get; set; }

        [StringLength(20)]
        public string GTZYJCGTZID { get; set; }

        [StringLength(20)]
        public string JSYDYSBGSID { get; set; }

        [StringLength(12)]
        public string SFJSID { get; set; }

        [StringLength(12)]
        public string SJSLID { get; set; }

        [StringLength(20)]
        public string SQRXXID { get; set; }

        [StringLength(12)]
        public string ZDXXID { get; set; }

        [StringLength(20)]
        public string GYCBBID { get; set; }

        [StringLength(20)]
        public string HBJDSID { get; set; }

        [StringLength(20)]
        public string GYJHBID { get; set; }

        [StringLength(20)]
        public string PJBGBABID { get; set; }

        [StringLength(40)]
        public string WZBM { get; set; }

        [StringLength(20)]
        public string FI_INST { get; set; }

        [StringLength(50)]
        public string SZHJ { get; set; }

        [StringLength(20)]
        public string GYTDSYQZRCBPID { get; set; }

        [StringLength(20)]
        public string GYTDZRQBSBID { get; set; }

        [StringLength(20)]
        public string DYSPDID { get; set; }

        [StringLength(20)]
        public string XMXXID { get; set; }

        [StringLength(20)]
        public string XXGGID { get; set; }

        [StringLength(50)]
        public string XMWZ { get; set; }

        [StringLength(50)]
        public string XMNF { get; set; }

        [StringLength(50)]
        public string SQYDDW { get; set; }

        [StringLength(50)]
        public string DQHJ { get; set; }

        [StringLength(20)]
        public string XMPZDID { get; set; }

        [StringLength(20)]
        public string NZZBID { get; set; }

        [StringLength(20)]
        public string JSYDQBSPID { get; set; }

        [StringLength(20)]
        public string CKID { get; set; }

        [StringLength(20)]
        public string CQHXXID { get; set; }

        [StringLength(50)]
        public string SJPD { get; set; }

        [StringLength(50)]
        public string TZCK { get; set; }

        [StringLength(50)]
        public string CQLX { get; set; }

        [StringLength(50)]
        public string TZXZ { get; set; }

        public decimal? FORMERFLAG { get; set; }

        [StringLength(20)]
        public string JSTJ { get; set; }
    }
}
