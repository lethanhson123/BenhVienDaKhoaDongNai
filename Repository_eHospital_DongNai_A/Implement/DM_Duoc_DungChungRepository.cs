namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_Duoc_DungChungRepository : BaseRepository<DM_Duoc_DungChung>
    , IDM_Duoc_DungChungRepository
    {
    private readonly Context _context;
    public DM_Duoc_DungChungRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

