namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DoiTuongCDTRepository : BaseRepository<DM_DoiTuongCDT>
    , IDM_DoiTuongCDTRepository
    {
    private readonly Context _context;
    public DM_DoiTuongCDTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

