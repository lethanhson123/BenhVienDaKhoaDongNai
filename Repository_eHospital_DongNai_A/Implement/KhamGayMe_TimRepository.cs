namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamGayMe_TimRepository : BaseRepository<KhamGayMe_Tim>
    , IKhamGayMe_TimRepository
    {
    private readonly Context _context;
    public KhamGayMe_TimRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

