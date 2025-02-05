namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_NGAYLERepository : BaseRepository<NS_DM_NGAYLE>
    , INS_DM_NGAYLERepository
    {
    private readonly Context _context;
    public NS_DM_NGAYLERepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

