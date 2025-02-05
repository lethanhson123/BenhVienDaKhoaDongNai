namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LyDoNghiViecRepository : BaseRepository<NS_DM_LyDoNghiViec>
    , INS_DM_LyDoNghiViecRepository
    {
    private readonly Context _context;
    public NS_DM_LyDoNghiViecRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

