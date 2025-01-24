namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_ICD_tmpRepository : BaseRepository<DM_ICD_tmp>
    , IDM_ICD_tmpRepository
    {
    private readonly Context _context;
    public DM_ICD_tmpRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

