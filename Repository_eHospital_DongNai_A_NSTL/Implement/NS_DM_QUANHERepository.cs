namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_QUANHERepository : BaseRepository<NS_DM_QUANHE>
    , INS_DM_QUANHERepository
    {
    private readonly Context _context;
    public NS_DM_QUANHERepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

