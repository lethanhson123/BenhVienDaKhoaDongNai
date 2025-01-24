namespace Repository_eHospital_DongNai_A.Implement
{
    public class TreSoSinhRepository : BaseRepository<TreSoSinh>
    , ITreSoSinhRepository
    {
    private readonly Context _context;
    public TreSoSinhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

