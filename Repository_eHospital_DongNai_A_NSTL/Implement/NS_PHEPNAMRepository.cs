namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_PHEPNAMRepository : BaseRepository<NS_PHEPNAM>
    , INS_PHEPNAMRepository
    {
    private readonly Context _context;
    public NS_PHEPNAMRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

