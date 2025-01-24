namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_PhacDoDieuTriRepository : BaseRepository<DM_PhacDoDieuTri>
    , IDM_PhacDoDieuTriRepository
    {
    private readonly Context _context;
    public DM_PhacDoDieuTriRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

