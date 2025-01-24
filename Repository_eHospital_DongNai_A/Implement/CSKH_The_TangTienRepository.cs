namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_TangTienRepository : BaseRepository<CSKH_The_TangTien>
    , ICSKH_The_TangTienRepository
    {
    private readonly Context _context;
    public CSKH_The_TangTienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

