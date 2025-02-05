namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_DinhSuatRepository : BaseRepository<NS_DM_DinhSuat>
    , INS_DM_DinhSuatRepository
    {
    private readonly Context _context;
    public NS_DM_DinhSuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

