namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChanPhauThuat_EkipRepository : BaseRepository<HoiChanPhauThuat_Ekip>
    , IHoiChanPhauThuat_EkipRepository
    {
    private readonly Context _context;
    public HoiChanPhauThuat_EkipRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

