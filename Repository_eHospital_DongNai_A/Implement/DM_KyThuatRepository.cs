namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_KyThuatRepository : BaseRepository<DM_KyThuat>
    , IDM_KyThuatRepository
    {
    private readonly Context _context;
    public DM_KyThuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

