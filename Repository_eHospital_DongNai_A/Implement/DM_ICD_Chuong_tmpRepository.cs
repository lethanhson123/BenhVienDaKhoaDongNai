namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_ICD_Chuong_tmpRepository : BaseRepository<DM_ICD_Chuong_tmp>
    , IDM_ICD_Chuong_tmpRepository
    {
    private readonly Context _context;
    public DM_ICD_Chuong_tmpRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

