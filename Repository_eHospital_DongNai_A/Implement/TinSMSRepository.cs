namespace Repository_eHospital_DongNai_A.Implement
{
    public class TinSMSRepository : BaseRepository<TinSMS>
    , ITinSMSRepository
    {
    private readonly Context _context;
    public TinSMSRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

