namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICD_ChuongRepository : BaseRepository<DM_ICD_Chuong>
    , IDM_ICD_ChuongRepository
    {
    private readonly Context _context;
    public DM_ICD_ChuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

