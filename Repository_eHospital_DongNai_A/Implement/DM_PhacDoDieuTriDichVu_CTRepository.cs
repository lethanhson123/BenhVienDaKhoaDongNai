namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_PhacDoDieuTriDichVu_CTRepository : BaseRepository<DM_PhacDoDieuTriDichVu_CT>
    , IDM_PhacDoDieuTriDichVu_CTRepository
    {
    private readonly Context _context;
    public DM_PhacDoDieuTriDichVu_CTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

