namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_PhanLoaiDoiTuongRepository : BaseRepository<CDT_KSK_PhanLoaiDoiTuong>
    , ICDT_KSK_PhanLoaiDoiTuongRepository
    {
    private readonly Context _context;
    public CDT_KSK_PhanLoaiDoiTuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

