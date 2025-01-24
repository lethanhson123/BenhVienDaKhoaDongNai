namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChanPhauThuatRepository : BaseRepository<HoiChanPhauThuat>
    , IHoiChanPhauThuatRepository
    {
    private readonly Context _context;
    public HoiChanPhauThuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

