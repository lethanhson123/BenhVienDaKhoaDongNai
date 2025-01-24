namespace Repository_eHospital_DongNai_A.Implement
{
    public class Import_DM_ICD_YHCTRepository : BaseRepository<Import_DM_ICD_YHCT>
    , IImport_DM_ICD_YHCTRepository
    {
    private readonly Context _context;
    public Import_DM_ICD_YHCTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

