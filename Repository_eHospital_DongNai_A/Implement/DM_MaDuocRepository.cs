namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_MaDuocRepository : BaseRepository<DM_MaDuoc>
    , IDM_MaDuocRepository
    {
    private readonly Context _context;
    public DM_MaDuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

