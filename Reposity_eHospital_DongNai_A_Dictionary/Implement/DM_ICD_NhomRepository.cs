namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICD_NhomRepository : BaseRepository<DM_ICD_Nhom>
    , IDM_ICD_NhomRepository
    {
    private readonly Context _context;
    public DM_ICD_NhomRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

