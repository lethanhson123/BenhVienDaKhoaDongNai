namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class DM_NgachBac_ExcelRepository : BaseRepository<DM_NgachBac_Excel>
    , IDM_NgachBac_ExcelRepository
    {
    private readonly Context _context;
    public DM_NgachBac_ExcelRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

