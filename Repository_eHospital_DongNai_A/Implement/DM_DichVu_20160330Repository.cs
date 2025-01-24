namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DichVu_20160330Repository : BaseRepository<DM_DichVu_20160330>
    , IDM_DichVu_20160330Repository
    {
    private readonly Context _context;
    public DM_DichVu_20160330Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

