
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
        public virtual DbSet<DM_DichVu> DM_DichVu { get; set; }
        public virtual DbSet<DM_DonViTinh> DM_DonViTinh { get; set; }
        public virtual DbSet<DM_ICD> DM_ICD { get; set; }
        public virtual DbSet<DM_ICD_Chuong> DM_ICD_Chuong { get; set; }
        public virtual DbSet<DM_ICD_Common> DM_ICD_Common { get; set; }
        public virtual DbSet<DM_ICD_Nhom> DM_ICD_Nhom { get; set; }
        public virtual DbSet<DM_KhoDuoc> DM_KhoDuoc { get; set; }
        public virtual DbSet<DM_NhomDichVu> DM_NhomDichVu { get; set; }
        public virtual DbSet<DM_PhongBan> DM_PhongBan { get; set; }
        public virtual DbSet<DM_LoaiDichVu> DM_LoaiDichVu { get; set; }
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
