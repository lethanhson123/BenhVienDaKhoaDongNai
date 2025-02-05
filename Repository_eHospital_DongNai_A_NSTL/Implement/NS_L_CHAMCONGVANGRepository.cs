namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_L_CHAMCONGVANGRepository : BaseRepository<NS_L_CHAMCONGVANG>
    , INS_L_CHAMCONGVANGRepository
    {
    private readonly Context _context;
    public NS_L_CHAMCONGVANGRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

