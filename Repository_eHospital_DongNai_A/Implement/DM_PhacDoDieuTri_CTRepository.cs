namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_PhacDoDieuTri_CTRepository : BaseRepository<DM_PhacDoDieuTri_CT>
    , IDM_PhacDoDieuTri_CTRepository
    {
    private readonly Context _context;
    public DM_PhacDoDieuTri_CTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

