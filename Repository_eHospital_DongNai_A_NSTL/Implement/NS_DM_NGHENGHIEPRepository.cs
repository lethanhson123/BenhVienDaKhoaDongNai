namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_NGHENGHIEPRepository : BaseRepository<NS_DM_NGHENGHIEP>
    , INS_DM_NGHENGHIEPRepository
    {
    private readonly Context _context;
    public NS_DM_NGHENGHIEPRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

