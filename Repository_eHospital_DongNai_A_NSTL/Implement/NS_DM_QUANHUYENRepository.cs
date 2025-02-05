namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_QUANHUYENRepository : BaseRepository<NS_DM_QUANHUYEN>
    , INS_DM_QUANHUYENRepository
    {
    private readonly Context _context;
    public NS_DM_QUANHUYENRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

