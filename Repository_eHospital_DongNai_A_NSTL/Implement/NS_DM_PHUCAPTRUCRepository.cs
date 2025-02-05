namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_PHUCAPTRUCRepository : BaseRepository<NS_DM_PHUCAPTRUC>
    , INS_DM_PHUCAPTRUCRepository
    {
    private readonly Context _context;
    public NS_DM_PHUCAPTRUCRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

