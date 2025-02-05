namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DAOTAORepository : BaseRepository<NS_DAOTAO>
    , INS_DAOTAORepository
    {
    private readonly Context _context;
    public NS_DAOTAORepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

