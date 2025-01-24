namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamBenh_TiemChungRepository : BaseRepository<KhamBenh_TiemChung>
    , IKhamBenh_TiemChungRepository
    {
    private readonly Context _context;
    public KhamBenh_TiemChungRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

