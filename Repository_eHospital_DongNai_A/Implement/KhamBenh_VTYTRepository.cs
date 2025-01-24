namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamBenh_VTYTRepository : BaseRepository<KhamBenh_VTYT>
    , IKhamBenh_VTYTRepository
    {
    private readonly Context _context;
    public KhamBenh_VTYTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

