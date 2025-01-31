namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_KhoDuocRepository : BaseRepository<DM_KhoDuoc>
    , IDM_KhoDuocRepository
    {
    private readonly Context _context;
    public DM_KhoDuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

