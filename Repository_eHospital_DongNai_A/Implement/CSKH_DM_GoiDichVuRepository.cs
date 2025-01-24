namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_DM_GoiDichVuRepository : BaseRepository<CSKH_DM_GoiDichVu>
    , ICSKH_DM_GoiDichVuRepository
    {
    private readonly Context _context;
    public CSKH_DM_GoiDichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

