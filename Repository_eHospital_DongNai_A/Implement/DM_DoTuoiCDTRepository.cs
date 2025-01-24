namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DoTuoiCDTRepository : BaseRepository<DM_DoTuoiCDT>
    , IDM_DoTuoiCDTRepository
    {
    private readonly Context _context;
    public DM_DoTuoiCDTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

