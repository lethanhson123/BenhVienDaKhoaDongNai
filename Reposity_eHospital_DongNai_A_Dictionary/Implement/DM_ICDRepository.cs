namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICDRepository : BaseRepository<DM_ICD>
    , IDM_ICDRepository
    {
    private readonly Context _context;
    public DM_ICDRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

