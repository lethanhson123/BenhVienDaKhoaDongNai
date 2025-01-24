namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamBenh_ICDRepository : BaseRepository<KhamBenh_ICD>
    , IKhamBenh_ICDRepository
    {
    private readonly Context _context;
    public KhamBenh_ICDRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

