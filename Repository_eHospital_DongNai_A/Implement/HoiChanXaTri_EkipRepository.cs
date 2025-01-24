namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChanXaTri_EkipRepository : BaseRepository<HoiChanXaTri_Ekip>
    , IHoiChanXaTri_EkipRepository
    {
    private readonly Context _context;
    public HoiChanXaTri_EkipRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

