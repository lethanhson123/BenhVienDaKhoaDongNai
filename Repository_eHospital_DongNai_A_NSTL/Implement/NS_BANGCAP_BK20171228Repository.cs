namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_BANGCAP_BK20171228Repository : BaseRepository<NS_BANGCAP_BK20171228>
    , INS_BANGCAP_BK20171228Repository
    {
    private readonly Context _context;
    public NS_BANGCAP_BK20171228Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

