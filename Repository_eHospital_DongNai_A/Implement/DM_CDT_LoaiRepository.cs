namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_CDT_LoaiRepository : BaseRepository<DM_CDT_Loai>
    , IDM_CDT_LoaiRepository
    {
    private readonly Context _context;
    public DM_CDT_LoaiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

