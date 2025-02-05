namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NGHIPHEPRepository : BaseRepository<NS_NGHIPHEP>
    , INS_NGHIPHEPRepository
    {
    private readonly Context _context;
    public NS_NGHIPHEPRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

