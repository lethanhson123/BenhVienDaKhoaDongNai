namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_SYS_tblFunctionListRepository : BaseRepository<NS_SYS_tblFunctionList>
    , INS_SYS_tblFunctionListRepository
    {
    private readonly Context _context;
    public NS_SYS_tblFunctionListRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

