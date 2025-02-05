namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_CaTrucRepository : BaseRepository<NS_DM_CaTruc>
    , INS_DM_CaTrucRepository
    {
    private readonly Context _context;
    public NS_DM_CaTrucRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

