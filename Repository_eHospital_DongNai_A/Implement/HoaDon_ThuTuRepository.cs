namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoaDon_ThuTuRepository : BaseRepository<HoaDon_ThuTu>
    , IHoaDon_ThuTuRepository
    {
    private readonly Context _context;
    public HoaDon_ThuTuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

