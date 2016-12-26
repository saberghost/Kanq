namespace Kanq.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OracleDbContext : DbContext
    {
        public OracleDbContext()
            : base("name=OracleDbContext")
        {
        }

        public virtual DbSet<TBL_GZMXB> TBL_GZMXB { get; set; }
        public virtual DbSet<TBL_GZMXB_LOG> TBL_GZMXB_LOG { get; set; }
        public virtual DbSet<TBL_GZMXB_TJ> TBL_GZMXB_TJ { get; set; }
        public virtual DbSet<TBL_JSYDBP_BCGDDJK_DETAIL> TBL_JSYDBP_BCGDDJK_DETAIL { get; set; }
        public virtual DbSet<TBL_JSYDBP_BCGDDJK_ZB1> TBL_JSYDBP_BCGDDJK_ZB1 { get; set; }
        public virtual DbSet<TBL_JSYDBP_BCGDDJK_ZB2> TBL_JSYDBP_BCGDDJK_ZB2 { get; set; }
        public virtual DbSet<D_REC> D_REC { get; set; }
        public virtual DbSet<TBL_SJSLD> TBL_SJSLD { get; set; }
        public virtual DbSet<TBL_TDFHDJ_BPPD> TBL_TDFHDJ_BPPD { get; set; }
        public virtual DbSet<TBL_HBGYTDSYQ_QBSPD> TBL_HBGYTDSYQ_QBSPD { get; set; }
        public virtual DbSet<TBL_HBGYTDSYQ_QBSPD_ZB> TBL_HBGYTDSYQ_QBSPD_ZB { get; set; }
        public virtual DbSet<TBL_TDGY_HBJDS> TBL_TDGY_HBJDS { get; set; }
        public virtual DbSet<TBL_TDTJBG_HTJBXX> TBL_TDTJBG_HTJBXX { get; set; }
        public virtual DbSet<OA2_FINST> OA2_FINST { get; set; }
        public virtual DbSet<TBL_TDFHDJ_BPPD_ZB> TBL_TDFHDJ_BPPD_ZB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
