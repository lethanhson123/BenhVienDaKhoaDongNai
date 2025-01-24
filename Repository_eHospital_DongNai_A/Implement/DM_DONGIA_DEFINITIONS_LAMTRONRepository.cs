namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DONGIA_DEFINITIONS_LAMTRONRepository : BaseRepository<DM_DONGIA_DEFINITIONS_LAMTRON>
    , IDM_DONGIA_DEFINITIONS_LAMTRONRepository
    {
    private readonly Context _context;
    public DM_DONGIA_DEFINITIONS_LAMTRONRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

