namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChanXaTriTrongRepository : BaseRepository<HoiChanXaTriTrong>
    , IHoiChanXaTriTrongRepository
    {
    private readonly Context _context;
    public HoiChanXaTriTrongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

