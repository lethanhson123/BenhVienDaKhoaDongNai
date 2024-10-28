
namespace Data.Context
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
        public virtual DbSet<Data.Model.DanhMucBenhVien> DanhMucBenhVien { get; set; }
        public virtual DbSet<Data.Model.DanhMucChucDanh> DanhMucChucDanh { get; set; }
        public virtual DbSet<Data.Model.DanhMucChucNang> DanhMucChucNang { get; set; }
        public virtual DbSet<Data.Model.DanhMucPhongBan> DanhMucPhongBan { get; set; }
        public virtual DbSet<Data.Model.DanhMucThanhVien> DanhMucThanhVien { get; set; }
        public virtual DbSet<Data.Model.DanhMucTinhTrang> DanhMucTinhTrang { get; set; }

        public virtual DbSet<Data.Model.ThanhVien> ThanhVien { get; set; }
        public virtual DbSet<Data.Model.ThanhVienChucNang> ThanhVienChucNang { get; set; }
        public virtual DbSet<Data.Model.ThanhVienLichSuTruyCap> ThanhVienLichSuTruyCap { get; set; }
        public virtual DbSet<Data.Model.ThanhVienToken> ThanhVienToken { get; set; }

        public virtual DbSet<Data.Model.CongViec> CongViec { get; set; }
        public virtual DbSet<Data.Model.CongViecTapTinDinhKem> CongViecTapTinDinhKem { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GlobalHelper.SQLServerConectionString);
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			OnModelCreatingPartial(modelBuilder);
		}
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
