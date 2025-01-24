namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_NhomTiemChungRepository : BaseRepository<DM_NhomTiemChung>
    , IDM_NhomTiemChungRepository
    {
    private readonly Context _context;
    public DM_NhomTiemChungRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

