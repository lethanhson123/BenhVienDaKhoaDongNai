namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_FORMULARSRepository : BaseRepository<NS_RP_FORMULARS>
    , INS_RP_FORMULARSRepository
    {
    private readonly Context _context;
    public NS_RP_FORMULARSRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

