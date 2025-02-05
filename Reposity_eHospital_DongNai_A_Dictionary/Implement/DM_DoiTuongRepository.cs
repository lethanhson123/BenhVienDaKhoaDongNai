namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DoiTuongRepository : BaseRepository<DM_DoiTuong>
    , IDM_DoiTuongRepository
    {
    private readonly Context _context;
    public DM_DoiTuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

