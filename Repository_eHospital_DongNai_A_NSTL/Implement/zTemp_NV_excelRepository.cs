namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class zTemp_NV_excelRepository : BaseRepository<zTemp_NV_excel>
    , IzTemp_NV_excelRepository
    {
    private readonly Context _context;
    public zTemp_NV_excelRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

