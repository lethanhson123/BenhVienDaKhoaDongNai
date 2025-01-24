namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DVT_ThoiGianRepository : BaseRepository<DM_DVT_ThoiGian>
    , IDM_DVT_ThoiGianRepository
    {
    private readonly Context _context;
    public DM_DVT_ThoiGianRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

