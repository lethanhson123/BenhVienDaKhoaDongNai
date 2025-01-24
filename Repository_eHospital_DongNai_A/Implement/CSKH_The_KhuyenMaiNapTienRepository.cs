namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_KhuyenMaiNapTienRepository : BaseRepository<CSKH_The_KhuyenMaiNapTien>
    , ICSKH_The_KhuyenMaiNapTienRepository
    {
    private readonly Context _context;
    public CSKH_The_KhuyenMaiNapTienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

