namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_TAIKHOANRepository : BaseRepository<DM_TAIKHOAN>
    , IDM_TAIKHOANRepository
    {
    private readonly Context _context;
    public DM_TAIKHOANRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

