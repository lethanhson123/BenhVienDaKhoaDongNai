namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_MucHuongDocHaiRepository : BaseRepository<NS_DM_MucHuongDocHai>
    , INS_DM_MucHuongDocHaiRepository
    {
    private readonly Context _context;
    public NS_DM_MucHuongDocHaiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

