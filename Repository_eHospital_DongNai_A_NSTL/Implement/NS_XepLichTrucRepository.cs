namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_XepLichTrucRepository : BaseRepository<NS_XepLichTruc>
    , INS_XepLichTrucRepository
    {
    private readonly Context _context;
    public NS_XepLichTrucRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

