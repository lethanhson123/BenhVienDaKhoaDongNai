namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_L_DMCHITIEURepository : BaseRepository<NS_L_DMCHITIEU>
    , INS_L_DMCHITIEURepository
    {
    private readonly Context _context;
    public NS_L_DMCHITIEURepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

