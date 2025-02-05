namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_DAOTAORepository : BaseRepository<NS_DM_DAOTAO>
    , INS_DM_DAOTAORepository
    {
    private readonly Context _context;
    public NS_DM_DAOTAORepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

