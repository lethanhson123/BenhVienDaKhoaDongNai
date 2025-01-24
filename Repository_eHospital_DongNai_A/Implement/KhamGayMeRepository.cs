namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamGayMeRepository : BaseRepository<KhamGayMe>
    , IKhamGayMeRepository
    {
    private readonly Context _context;
    public KhamGayMeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

