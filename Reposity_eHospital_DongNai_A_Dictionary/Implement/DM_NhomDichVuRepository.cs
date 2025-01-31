namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_NhomDichVuRepository : BaseRepository<DM_NhomDichVu>
    , IDM_NhomDichVuRepository
    {
    private readonly Context _context;
    public DM_NhomDichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

