namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamGayMe_TreEmRepository : BaseRepository<KhamGayMe_TreEm>
    , IKhamGayMe_TreEmRepository
    {
    private readonly Context _context;
    public KhamGayMe_TreEmRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

