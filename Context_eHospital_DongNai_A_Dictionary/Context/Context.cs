
namespace Data_eHospital_DongNai_A_Dictionary.Context
{
	public partial class Context : DbContext
	{
		public Context()
		{
		}
		public Context(DbContextOptions<Context> options)
        : base(options)
        {
		}
        public virtual DbSet<DM_BenhNhan> DM_BenhNhan { get; set; }
        public virtual DbSet<DM_BenhNhan_BHYT> DM_BenhNhan_BHYT { get; set; }
        public virtual DbSet<DM_BenhVien> DM_BenhVien { get; set; }
        public virtual DbSet<DM_DonViHanhChinh> DM_DonViHanhChinh { get; set; }
        public virtual DbSet<Lst_Dictionary> Lst_Dictionary { get; set; }
        public virtual DbSet<Lst_Dictionary_Type> Lst_Dictionary_Type { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A_Dictionary);
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			OnModelCreatingPartial(modelBuilder);
		}
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
