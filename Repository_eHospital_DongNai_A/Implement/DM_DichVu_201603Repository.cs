namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DichVu_201603Repository : BaseRepository<DM_DichVu_201603>
    , IDM_DichVu_201603Repository
    {
    private readonly Context _context;
    public DM_DichVu_201603Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

