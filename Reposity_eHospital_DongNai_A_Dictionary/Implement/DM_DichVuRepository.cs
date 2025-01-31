namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DichVuRepository : BaseRepository<DM_DichVu>
    , IDM_DichVuRepository
    {
    private readonly Context _context;
    public DM_DichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

