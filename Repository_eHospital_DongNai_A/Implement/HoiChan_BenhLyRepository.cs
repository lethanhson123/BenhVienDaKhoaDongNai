namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChan_BenhLyRepository : BaseRepository<HoiChan_BenhLy>
    , IHoiChan_BenhLyRepository
    {
    private readonly Context _context;
    public HoiChan_BenhLyRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

