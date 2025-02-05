namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NGOAINGU_UVRepository : BaseRepository<NS_NGOAINGU_UV>
    , INS_NGOAINGU_UVRepository
    {
    private readonly Context _context;
    public NS_NGOAINGU_UVRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

