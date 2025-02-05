namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_CONGTACRepository : BaseRepository<NS_CONGTAC>
    , INS_CONGTACRepository
    {
    private readonly Context _context;
    public NS_CONGTACRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

