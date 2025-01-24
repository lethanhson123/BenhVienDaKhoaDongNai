namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_NapTienRepository : BaseRepository<CSKH_The_NapTien>
    , ICSKH_The_NapTienRepository
    {
    private readonly Context _context;
    public CSKH_The_NapTienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

