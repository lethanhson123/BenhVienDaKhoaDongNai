namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChanXaTriRepository : BaseRepository<HoiChanXaTri>
    , IHoiChanXaTriRepository
    {
    private readonly Context _context;
    public HoiChanXaTriRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

