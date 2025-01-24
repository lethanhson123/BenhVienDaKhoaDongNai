namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_TAIKHOAN_MAPRepository : BaseRepository<DM_TAIKHOAN_MAP>
    , IDM_TAIKHOAN_MAPRepository
    {
    private readonly Context _context;
    public DM_TAIKHOAN_MAPRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

