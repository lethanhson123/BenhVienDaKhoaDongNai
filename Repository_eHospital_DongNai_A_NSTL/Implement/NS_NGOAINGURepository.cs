namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NGOAINGURepository : BaseRepository<NS_NGOAINGU>
    , INS_NGOAINGURepository
    {
    private readonly Context _context;
    public NS_NGOAINGURepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

