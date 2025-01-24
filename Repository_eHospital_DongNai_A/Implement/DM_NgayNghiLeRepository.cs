namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_NgayNghiLeRepository : BaseRepository<DM_NgayNghiLe>
    , IDM_NgayNghiLeRepository
    {
    private readonly Context _context;
    public DM_NgayNghiLeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

