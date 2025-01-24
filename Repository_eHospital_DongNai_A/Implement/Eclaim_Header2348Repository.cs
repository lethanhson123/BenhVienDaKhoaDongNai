namespace Repository_eHospital_DongNai_A.Implement
{
    public class Eclaim_Header2348Repository : BaseRepository<Eclaim_Header2348>
    , IEclaim_Header2348Repository
    {
    private readonly Context _context;
    public Eclaim_Header2348Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

