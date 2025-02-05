namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_LICHTRUCRepository : BaseRepository<NS_LICHTRUC>
    , INS_LICHTRUCRepository
    {
    private readonly Context _context;
    public NS_LICHTRUCRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

