namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_LSTFILTERRepository : BaseRepository<NS_RP_LSTFILTER>
    , INS_RP_LSTFILTERRepository
    {
    private readonly Context _context;
    public NS_RP_LSTFILTERRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

