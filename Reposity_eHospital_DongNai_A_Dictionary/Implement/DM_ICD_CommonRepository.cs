namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICD_CommonRepository : BaseRepository<DM_ICD_Common>
    , IDM_ICD_CommonRepository
    {
    private readonly Context _context;
    public DM_ICD_CommonRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

