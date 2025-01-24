namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_ThuocTiemChungRepository : BaseRepository<DM_ThuocTiemChung>
    , IDM_ThuocTiemChungRepository
    {
    private readonly Context _context;
    public DM_ThuocTiemChungRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

