namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NhanVien_PhongBanRepository : BaseRepository<NS_NhanVien_PhongBan>
    , INS_NhanVien_PhongBanRepository
    {
    private readonly Context _context;
    public NS_NhanVien_PhongBanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

