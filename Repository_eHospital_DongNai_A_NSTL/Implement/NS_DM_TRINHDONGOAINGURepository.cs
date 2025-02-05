namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TRINHDONGOAINGURepository : BaseRepository<NS_DM_TRINHDONGOAINGU>
    , INS_DM_TRINHDONGOAINGURepository
    {
    private readonly Context _context;
    public NS_DM_TRINHDONGOAINGURepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

