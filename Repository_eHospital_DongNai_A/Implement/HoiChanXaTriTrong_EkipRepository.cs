namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChanXaTriTrong_EkipRepository : BaseRepository<HoiChanXaTriTrong_Ekip>
    , IHoiChanXaTriTrong_EkipRepository
    {
    private readonly Context _context;
    public HoiChanXaTriTrong_EkipRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

