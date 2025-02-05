namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NGACHBACLUONGRepository : BaseRepository<NS_NGACHBACLUONG>
    , INS_NGACHBACLUONGRepository
    {
    private readonly Context _context;
    public NS_NGACHBACLUONGRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

