namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_NHOMRepository : BaseRepository<NS_DM_NHOM>
    , INS_DM_NHOMRepository
    {
    private readonly Context _context;
    public NS_DM_NHOMRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

