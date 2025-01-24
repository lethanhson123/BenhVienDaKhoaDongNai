namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChanRepository : BaseRepository<HoiChan>
    , IHoiChanRepository
    {
    private readonly Context _context;
    public HoiChanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

