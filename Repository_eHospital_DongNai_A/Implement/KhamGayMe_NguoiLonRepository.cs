namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamGayMe_NguoiLonRepository : BaseRepository<KhamGayMe_NguoiLon>
    , IKhamGayMe_NguoiLonRepository
    {
    private readonly Context _context;
    public KhamGayMe_NguoiLonRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

